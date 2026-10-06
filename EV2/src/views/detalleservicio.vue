<script setup>
import { computed } from 'vue'
import { useRoute, RouterLink } from 'vue-router'
import { servicios } from '../data/servicios'

const route = useRoute()

const servicioId = route.params.id

const servicio = computed(() => {
  return servicios.find(s => String(s.id) === String(servicioId))
})
</script>

<template>
  <section class="detalle-container">
    <div v-if="servicio" class="detalle-card">
      <h1>{{ servicio.nombre }}</h1>
      <p class="categoria"><strong>Categoría:</strong> {{ servicio.categoria }}</p>
      <p class="descripcion"><strong>Descripción:</strong> {{ servicio.descripcion }}</p>
      <p class="precio"><strong>Precio:</strong> ${{ servicio.precio }}</p>
      <p class="disponibilidad">
        <strong>Disponibilidad:</strong> 
        <span :class="servicio.disponible ? 'disponible' : 'no-disponible'">
          {{ servicio.disponible ? 'Disponible' : 'No disponible' }}
        </span>
      </p>

      <RouterLink to="/servicios" class="btn-volver">← Volver a servicios</RouterLink>
    </div>

    <div v-else class="error-servicio">
      <h2>El servicio no existe</h2>
      <p>El identificador "{{ servicioId }}" no corresponde a un servicio válido.</p>
      <RouterLink to="/servicios" class="btn-volver">Volver al catálogo</RouterLink>
    </div>
  </section>
</template>

<style scoped>
.detalle-container {
  max-width: 800px;
  margin: 2rem auto;
  padding: 1rem;
}

.disponible {
  color: #16a34a;
  font-weight: bold;
}

.no-disponible {
  color: #dc2626;
  font-weight: bold;
}

.error-servicio {
  text-align: center;
  padding: 3rem;
  background-color: #fef2f2;
  border: 1px solid #fecaca;
  border-radius: 8px;
  color: #991b1b;
}

.btn-volver {
  display: inline-block;
  margin-top: 1rem;
  padding: 0.5rem 1rem;
  background-color: #3b82f6;
  color: white;
  text-decoration: none;
  border-radius: 6px;
}
</style>