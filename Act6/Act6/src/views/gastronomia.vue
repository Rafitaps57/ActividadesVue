<template>
  <div class="container">
    <h1 class="page-title">Gastronomía Local</h1>
    <p class="page-subtitle">Los sabores autóctonos de la Región de Ñuble.</p>

    <div class="grid-cards">
      <TarjetaLugar
        v-for="(plato, index) in platos"
        :key="index"
        :titulo="plato.titulo"
        :descripcion="plato.descripcion"
        :imagen="plato.imagen"
        categoria="Gastronomía"
      />
    </div>
  </div>
</template>

<script setup>
import TarjetaLugar from '../components/TarjetaLugar.vue'

const platos = [
  {
    titulo: 'Longanizas de Chillán',
    descripcion: 'El producto estrella de la ciudad, elaborada con receta tradicional artesanal a base de cerdo aliñado y ahumado.',
    imagen: 'https://images.unsplash.com/photo-1555939594-58d7cb561ad1?w=600'
  },
  {
    titulo: 'Pan Amasado',
    descripcion: 'Preparado a mano y horneado diariamente en barro, acompañamiento infaltable en la mesa chillaneja.',
    imagen: 'https://images.unsplash.com/photo-1509440159596-0249088772ff?w=600'
  },
  {
    titulo: 'Vinos del Valle del Itata',
    descripcion: 'Vinos con denominación de origen de cepas ancestrales como País, Moscatel y Cinsault cultivadas en el cercano Valle del Itata.',
    imagen: 'https://images.unsplash.com/photo-1510812431401-41d2bd2722f3?w=600'
  }
]
</script>