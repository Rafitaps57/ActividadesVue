<script setup>
import { ref, computed, onMounted } from 'vue'
import ProductoCard from '../components/ProductoCard.vue'
import { productos } from '../data/productos'

// Estado para el texto que escribe el usuario en el input
const textoBusqueda = ref('')
// Estado que realmente se usa para filtrar (se actualiza al hacer clic en Buscar)
const buscar = ref('')
const categoria = ref('Todas')
const favoritos = ref([])

// Ejecuta la búsqueda explícitamente
function ejecutarBusqueda() {
  buscar.value = textoBusqueda.value.trim()
}

// Limpia el campo de texto y el filtro
function limpiarBusqueda() {
  textoBusqueda.value = ''
  buscar.value = ''
}

const categorias = computed(() => {
  return ['Todas', ...new Set(productos.map(p => p.categoria))]
})

const productosFiltrados = computed(() => {
  return productos.filter(producto => {
    const coincideTexto = producto.nombre
      .toLowerCase()
      .includes(buscar.value.toLowerCase())
    const coincideCategoria =
      categoria.value === 'Todas' ||
      producto.categoria === categoria.value
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
          placeholder="Buscar producto..." 
          class="input-buscar"
          @keyup.enter="ejecutarBusqueda"
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
        <button type="button" class="btn-buscar" @click="ejecutarBusqueda">
          🔍 Buscar
        </button>
      </div>

      <select v-model="categoria" class="select-categoria">
        <option v-for="cat in categorias" :key="cat" :value="cat">
          {{ cat }}
        </option>
      </select>
    </div>

    <div v-if="productosFiltrados.length" class="productos-grid">
      <ProductoCard
        v-for="producto in productosFiltrados"
        :key="producto.id"
        :producto="producto"
        :favorito="favoritos.includes(producto.id)"
        @cambiar-favorito="cambiarFavorito"
      />
    </div>

    <div v-else class="sin-resultados">
      <p>No existen productos que coincidan con la búsqueda.</p>
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
  border-radius: 8px 0 0 8px;
  font-size: 0.95rem;
  outline: none;
  transition: border-color 0.2s ease;
}

.input-buscar:focus {
  border-color: #3b82f6;
}

.btn-limpiar {
  position: absolute;
  right: 110px;
  background: transparent;
  border: none;
  color: #94a3b8;
  font-size: 0.9rem;
  cursor: pointer;
  padding: 0.2rem 0.5rem;
}

.btn-limpiar:hover {
  color: #64748b;
}

.btn-buscar {
  padding: 0.65rem 1.25rem;
  background-color: #3b82f6;
  color: white;
  border: 2px solid #3b82f6;
  border-radius: 0 8px 8px 0;
  font-weight: 600;
  cursor: pointer;
  white-space: nowrap;
  transition: background-color 0.2s ease;
}

.btn-buscar:hover {
  background-color: #2563eb;
  border-color: #2563eb;
}

.select-categoria {
  padding: 0.65rem 1rem;
  border: 2px solid #e2e8f0;
  border-radius: 8px;
  background-color: white;
  font-size: 0.95rem;
  color: #334155;
  outline: none;
  cursor: pointer;
  transition: border-color 0.2s ease;
}

.select-categoria:focus {
  border-color: #3b82f6;
}

.productos-grid {
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(250px, 1fr));
  gap: 1.5rem;
}

.sin-resultados {
  text-align: center;
  padding: 3rem 1rem;
  background-color: #f8fafc;
  border-radius: 8px;
  color: #64748b;
  font-size: 1.1rem;
}
</style>