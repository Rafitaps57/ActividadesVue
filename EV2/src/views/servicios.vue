<script setup>
import { ref, computed, onMounted } from 'vue'
import servicioCard from '../components/serviciocard.vue'
import { servicios } from '../data/servicios'

// Vinculación directa con los controles
const textoBusqueda = ref('')
const categoria = ref('Todas')
const favoritos = ref([])

function limpiarBusqueda() {
  textoBusqueda.value = ''
}

const categorias = computed(() => {
  return ['Todas', ...new Set(servicios.map(p => p.categoria))]
})

// Filtrado reactivo en tiempo real con v-model
const serviciosFiltrados = computed(() => {
  return servicios.filter(servicio => {
    const coincideTexto = servicio.nombre
      .toLowerCase()
      .includes(textoBusqueda.value.trim().toLowerCase())
    const coincideCategoria =
      categoria.value === 'Todas' ||
      servicio.categoria === categoria.value
    return coincideTexto && coincideCategoria
  })
})

function cambiarFavorito(id) {
  if (favoritos.value.includes(id)) {
    favoritos.value = favoritos.value.filter(item => item !== id)
  } else {
    favoritos.value.push(id)
  }
  localStorage.setItem('favoritos', JSON.stringify(favoritos.value))
}

onMounted(() => {
  const guardados = localStorage.getItem('favoritos')
  if (guardados) favoritos.value = JSON.parse(guardados)
})
</script>
<template>
  <section class="pagina">
    <h1 class="titulo">Catálogo</h1>

    <div class="filtros">
      <div class="buscador-box">
        <input 
          v-model="textoBusqueda" 
          type="text"
          placeholder="Buscar Servicio..." 
          class="input-buscar"
        />
        <button 
          v-if="textoBusqueda" 
          type="button" 
          class="btn-limpiar"
          title="Limpiar búsqueda"
          @click="limpiarBusqueda"
        >
          ✕
        </button>
      </div>

      <select v-model="categoria" class="select-categoria">
        <option v-for="cat in categorias" :key="cat" :value="cat">
          {{ cat }}
        </option>
      </select>
    </div>

    <!-- v-if / v-else -->
    <div v-if="serviciosFiltrados.length" class="servicios-grid">
      <servicioCard
        v-for="servicio in serviciosFiltrados"
        :key="servicio.id"
        :servicio="servicio"
        :favorito="favoritos.includes(servicio.id)"
        @cambiar-favorito="cambiarFavorito"
      />
    </div>

    <div v-else class="sin-resultados">
      <p>No se encontraron servicios para los criterios seleccionados.</p>
    </div>
  </section>
</template>