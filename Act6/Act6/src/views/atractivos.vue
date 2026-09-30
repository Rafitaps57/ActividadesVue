<template>
  <div class="container">
    <h1 class="page-title">Atractivos Turísticos</h1>
    <p class="page-subtitle">Descubre los puntos emblemáticos de Chillán y sus alrededores.</p>

    <div class="grid-cards">
      <TarjetaLugar
        v-for="(item, index) in atractivos"
        :key="index"
        :titulo="item.titulo"
        :descripcion="item.descripcion"
        :imagen="item.imagen"
        categoria="Turismo"
      />
    </div>
  </div>
</template>

<script setup>
import TarjetaLugar from '../components/TarjetaLugar.vue'

const atractivos = [
  {
    titulo: 'Catedral de Chillán',
    descripcion: 'Icono arquitectónico modernista construido tras el terremoto de 1939, con su imponente arco de 39 metros de altura.',
    imagen: 'https://images.unsplash.com/photo-1548625361-180a0684db41?w=600'
  },
  {
    titulo: 'Termas de Chillán',
    descripcion: 'Complejo termal y centro de esquí ubicado a las faldas del volcán Chillán, famoso por sus aguas curativas y paisajes nevados.',
    imagen: 'https://images.unsplash.com/photo-1542601906990-b4d3fb778b09?w=600'
  },
  {
    titulo: 'Valle Las Trancas',
    descripcion: 'Pueblo de montaña rodeado de bosques nativos, ideal para el trekking, eco-turismo y actividades al aire libre durante todo el año.',
    imagen: 'https://images.unsplash.com/photo-1464822759023-fed622ff2c3b?w=600'
  },
  {
    titulo: 'Feria de Chillán',
    descripcion: 'Uno de los mercados al aire libre más tradicionales del país, donde abundan las artesanías en greda de Quinchamalí y productos agrícolas.',
    imagen: 'https://images.unsplash.com/photo-1488459716781-31db52582fe9?w=600'
  }
]
</script>