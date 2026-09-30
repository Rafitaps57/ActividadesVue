<template>
  <div class="vista">
    <h1>Catálogo de Servicios</h1>

    <!-- Filtro interactivo -->
    <div class="filtros">
      <input v-model="busqueda" placeholder="Buscar por nombre..." />
      <select v-model="categoriaSeleccionada">
        <option value="">Todas las categorías</option>
        <option value="Desarrollo">Desarrollo</option>
        <option value="Soporte">Soporte</option>
        <option value="Infraestructura">Infraestructura</option>
        <option value="Consultoría">Consultoría</option>
      </select>
    </div>

    <!-- Alerta de servicio seleccionado por $emit -->
    <div v-if="servicioSeleccionado" class="alerta-seleccion">
      <p>Has seleccionado: <strong>{{ servicioSeleccionado.nombre }}</strong></p>
      <router-link :to="{ path: '/contacto', query: { servicio: servicioSeleccionado.nombre } }">
        Ir al formulario de contacto
      </router-link>
    </div>

    <!-- Lista dinámica de servicios -->
    <div v-if="serviciosFiltrados.length > 0" class="grid-servicios">
      <ServicioCard 
        v-for="s in serviciosFiltrados" 
        :key="s.id" 
        :servicio="s"
        @seleccionar="marcarServicio"
      />
    </div>
    <p v-else class="sin-resultados">No se encontraron servicios que coincidan con la búsqueda.</p>
  </div>
</template>

<script>
import { serviciosData } from '../data/servicios'
import TarjetaServicio from '../components/TarjetaServicio.vue'

export default {
  name: 'ServiciosView',
  components: { TarjetaServicio },
  data() {
    return {
      servicios: serviciosData,
      busqueda: '',
      categoriaSeleccionada: '',
      servicioSeleccionado: null
    }
  },
  computed: {
    serviciosFiltrados() {
      return this.servicios.filter(s => {
        const coincideNombre = s.nombre.toLowerCase().includes(this.busqueda.toLowerCase())
        const coincideCategoria = this.categoriaSeleccionada === '' || s.categoria === this.categoriaSeleccionada
        return coincideNombre && coincideCategoria
      })
    }
  },
  methods: {
    marcarServicio(servicio) {
      this.servicioSeleccionado = servicio
    }
  }
}
</script>

<style scoped>
.filtros { display: flex; gap: 10px; margin-bottom: 20px; }
.filtros input, .filtros select { padding: 8px; flex: 1; }
.grid-servicios { display: grid; grid-template-columns: repeat(auto-fill, minmax(250px, 1fr)); gap: 15px; }
.alerta-seleccion { background: #e3f2fd; padding: 12px; border-radius: 6px; margin-bottom: 20px; }
.sin-resultados { text-align: center; color: #777; margin-top: 30px; }
</style>