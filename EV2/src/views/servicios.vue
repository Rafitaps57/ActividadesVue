<script setup>
import { ref, computed, onMounted } from 'vue'
import servicioCard from '../components/serviciocard.vue'

const servicios = ref([])
const cargando = ref(true)
const errorPeticion = ref(null)

const textoBusqueda = ref('')
const categoria = ref('Todas')
const favoritos = ref([])

async function obtenerServicios() {
  cargando.value = true
  errorPeticion.value = null

  try {
    const respuesta = await fetch('/servicios.json')
    
    if (!respuesta.ok) {
      throw new Error(`Error en la respuesta del servidor (${respuesta.status})`)
    }

    const datos = await respuesta.json()
    servicios.value = datos
  } catch (err) {
    console.error('Error al cargar servicios:', err)
    errorPeticion.value = 'Ocurrió un error al cargar los servicios. Por favor, reintenta más tarde.'
  } finally {
    cargando.value = false
  }
}

const categorias = computed(() => {
  return ['Todas', ...new Set(servicios.value.map(p => p.categoria))]
})

const serviciosFiltrados = computed(() => {
  return servicios.value.filter(servicio => {
    const coincideTexto = servicio.nombre
      .toLowerCase()
      .includes(textoBusqueda.value.trim().toLowerCase())
    const coincideCategoria =
      categoria.value === 'Todas' ||
      servicio.categoria === categoria.value
    return coincideTexto && coincideCategoria
  })
})

function limpiarBusqueda() {
  textoBusqueda.value = ''
}

function cambiarFavorito(id) {
  if (favoritos.value.includes(id)) {
    favoritos.value = favoritos.value.filter(item => item !== id)
  } else {
    favoritos.value.push(id)
  }
  localStorage.setItem('favoritos', JSON.stringify(favoritos.value))
}

onMounted(() => {
  obtenerServicios()
  
  const guardados = localStorage.getItem('favoritos')
  if (guardados) favoritos.value = JSON.parse(guardados)
})
</script>

<template>
  <section class="pagina">
    <h1 class="titulo">Catálogo de Servicios</h1>

    <div v-if="cargando" class="estado-mensaje cargando">
      <div class="spinner"></div>
      <p>Cargando servicios...</p>
    </div>

    <div v-else-if="errorPeticion" class="estado-mensaje error">
      <p>⚠️ {{ errorPeticion }}</p>
      <button type="button" class="btn-reintentar" @click="obtenerServicios">
        Reintentar
      </button>
    </div>

    <div v-else>
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
    </div>
  </section>
</template>

<style scoped>
.pagina {
  max-width: 1200px;
  margin: 0 auto;
  padding: 2rem 1rem;
}

.titulo {
  font-size: 2rem;
  font-weight: 700;
  color: #2c3e50;
  margin-bottom: 1.5rem;
}

.estado-mensaje {
  text-align: center;
  padding: 3rem 1rem;
  border-radius: 12px;
  margin: 2rem 0;
}

.cargando {
  background-color: #f1f5f9;
  color: #475569;
  font-size: 1.2rem;
}

.error {
  background-color: #fef2f2;
  border: 1px solid #fecaca;
  color: #991b1b;
  font-size: 1.1rem;
}

.spinner {
  width: 40px;
  height: 40px;
  margin: 0 auto 1rem;
  border: 4px solid #cbd5e1;
  border-top-color: #3b82f6;
  border-radius: 50%;
  animation: spin 1s linear infinite;
}

@keyframes spin {
  to { transform: rotate(360deg); }
}

.btn-reintentar {
  margin-top: 1rem;
  padding: 0.5rem 1.25rem;
  background-color: #dc2626;
  color: white;
  border: none;
  border-radius: 6px;
  cursor: pointer;
  font-weight: 600;
}

/* Filtros y Grilla */
.filtros {
  display: flex;
  flex-wrap: wrap;
  gap: 1rem;
  align-items: center;
  margin-bottom: 2rem;
}

.buscador-box {
  position: relative;
  display: flex;
  align-items: center;
  flex: 1;
  min-width: 280px;
}

.input-buscar {
  width: 100%;
  padding: 0.65rem 2.5rem 0.65rem 1rem;
  border: 2px solid #e2e8f0;
  border-radius: 8px;
  font-size: 0.95rem;
  outline: none;
}

.btn-limpiar {
  position: absolute;
  right: 10px;
  background: transparent;
  border: none;
  color: #94a3b8;
  cursor: pointer;
}

.select-categoria {
  padding: 0.65rem 1rem;
  border: 2px solid #e2e8f0;
  border-radius: 8px;
  background-color: white;
  font-size: 0.95rem;
  outline: none;
}

.servicios-grid {
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(280px, 1fr));
  gap: 1.5rem;
}

.sin-resultados {
  text-align: center;
  padding: 3rem 1rem;
  background-color: #f8fafc;
  border-radius: 8px;
  color: #64748b;
}
</style>