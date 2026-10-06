<script setup>
//aqui esta difinido
defineProps({
  servicio: {
    type: Object,
    required: true
  },
  favorito: {
    type: Boolean,
    default: false
  }
})

const emit = defineEmits(['cambiar-favorito'])
</script>

<template>
  <article class="producto-card">
    <img :src="servicio.imagen" :alt="servicio.nombre" />
    <div class="contenido-producto">
      <span class="categoria">{{ servicio.categoria }}</span>
      <h3>{{ servicio.nombre }}</h3>
      <p v-if="servicio.comuna">{{ servicio.comuna }}</p>
      <p>{{ servicio.descripcion }}</p>
      <p>{{ servicio.disponibilidad }}</p>
      <strong>${{ servicio.precio?.toLocaleString('es-CL') }}</strong>
      
      <div class="acciones">
        <RouterLink :to="`/servicios/${servicio.id}`" class="btn-detalle">
          Ver detalle
        </RouterLink>

        <button type="button" @click="emit('cambiar-favorito', servicio.id)">
          {{ favorito ? '★ Favorito' : '☆ Agregar' }}
        </button>
      </div>
    </div>
  </article>
</template>