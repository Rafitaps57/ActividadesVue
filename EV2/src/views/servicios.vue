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
  max-width: 1120px;
  margin: 0 auto;
}

.titulo {
  font-size: 1.8rem;
  font-weight: 800;
  color: var(--text-main);
  margin-bottom: 1.5rem;
}

/* Filtros */
.filtros {
  display: flex;
  flex-wrap: wrap;
  gap: 1rem;
  align-items: center;
  background-color: var(--bg-card);
  padding: 1.25rem;
  border-radius: var(--radius-md);
  border: 1px solid var(--border-color);
  box-shadow: var(--shadow-sm);
  margin-bottom: 2rem;
}

.buscador-box {
  position: relative;
  display: flex;
  align-items: center;
  flex: 1;
  min-width: 260px;
}

.input-buscar {
  width: 100%;
  padding: 0.7rem 2.5rem 0.7rem 1rem;
  border: 1px solid var(--border-color);
  border-radius: var(--radius-sm);
  font-size: 0.95rem;
  outline: none;
  transition: border-color 0.2s;
}

.input-buscar:focus {
  border-color: var(--primary);
}

.btn-limpiar {
  position: absolute;
  right: 12px;
  background: transparent;
  border: none;
  color: var(--text-muted);
  font-size: 0.9rem;
  cursor: pointer;
}

.select-categoria {
  padding: 0.7rem 1rem;
  border: 1px solid var(--border-color);
  border-radius: var(--radius-sm);
  background-color: white;
  font-size: 0.95rem;
  outline: none;
  cursor: pointer;
}

/* Grilla */
.servicios-grid {
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(280px, 1fr));
  gap: 1.5rem;
}

/* Estado Sin Resultados y Errores */
.sin-resultados,
.estado-mensaje {
  text-align: center;
  padding: 3rem 1.5rem;
  background-color: var(--bg-card);
  border: 1px dashed var(--border-color);
  border-radius: var(--radius-md);
  color: var(--text-muted);
  font-size: 1.1rem;
}
</style>