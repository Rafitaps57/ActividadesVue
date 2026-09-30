<script setup>
import { ref, computed } from 'vue'
import { useRecepcionStore } from '../stores/useRecepcionStore.js'
import ItemsRecepcion from './ItemsRecepcion.vue'

const { state } = useRecepcionStore()

const form = ref({ fecha: '', nro_guia: '', id_proveedor: '' })
const seleccion = ref(null)

function guardar(){
  if(!form.value.id_proveedor){
    alert('Seleccione proveedor')
    return // Corrección: Detener la ejecución si no hay proveedor
  }
  
  const nuevaRecepcion = { 
    id: Date.now(), 
    fecha: form.value.fecha, 
    nro_guia: form.value.nro_guia, 
    id_proveedor: Number(form.value.id_proveedor) 
  }
  
  state.recepciones.push(nuevaRecepcion)
  seleccion.value = nuevaRecepcion.id
  form.value = { fecha: '', nro_guia: '', id_proveedor: '' }
}

const lista = computed(() => state?.recepciones || [])

// Cálculo total de libros recibidos por id_recepcion
function getTotalLibros(idRecepcion) {
  const items = (state?.items || []).filter(it => it.id_recepcion === idRecepcion)
  return items.reduce((acc, current) => acc + Number(current.cantidad || 0), 0)
}

// Cálculo del porcentaje de ítems con problemas (dañado o mixto)
function getPorcentajeDefectuosos(idRecepcion) {
  const items = (state?.items || []).filter(it => it.id_recepcion === idRecepcion)
  if (items.length === 0) return '0.0'

  const problematicos = items.filter(it => it.estado === 'dañado' || it.estado === 'mixto')
  const porcentaje = (problematicos.length / items.length) * 100
  return porcentaje.toFixed(1)
}
</script>

<template>
  <div>
    <h2>Recepciones</h2>

    <form @submit.prevent="guardar">
      <input type="date" v-model="form.fecha" required />
      <input v-model="form.nro_guia" placeholder="N° Guía/Factura" required />
      <select v-model="form.id_proveedor" required>
        <option value="">-- Proveedor --</option>
        <option v-for="p in state?.proveedores || []" :key="p.id" :value="p.id">{{ p.nombre }}</option>
      </select>
      <button type="submit">Agregar</button>
    </form>

    <table class="table">
      <thead>
        <tr>
          <th>#</th>
          <th>Fecha</th>
          <th>Proveedor</th>
          <th>N° Guía</th>
          <th>Total Libros</th>
          <th>% Def.</th>
          <th>Detalle</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="r in lista" :key="r.id">
          <td>{{ r.id }}</td>
          <td>{{ r.fecha }}</td>
          <td>{{ (state?.proveedores || []).find(p => p.id === r.id_proveedor)?.nombre || '—' }}</td>
          <td>{{ r.nro_guia }}</td>
          <td>{{ getTotalLibros(r.id) }}</td>
          <td>{{ getPorcentajeDefectuosos(r.id) }}%</td>
          <td>
            <button @click="seleccion = r.id">Ver</button>
          </td>
        </tr>
      </tbody>
    </table>

    <ItemsRecepcion :id-recepcion="seleccion" /> 
  </div>
</template>
