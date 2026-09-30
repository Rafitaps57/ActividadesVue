<script setup>
import { ref } from 'vue'

const listaProductores = ref([
  { id: 1, nombre: 'Apícola Los Lleuques', comuna: 'Pinto', rubro: 'Apicultura', descripcion: 'Dedicados a la extracción de miel multifloral en la zona precordillerana de Ñuble.' },
  { id: 2, nombre: 'Viña Viejas Cepas', comuna: 'Portezuelo', rubro: 'Vitivinícola', descripcion: 'Tradición familiar cosechando cepas patrimoniales en el Valle del Itata.' },
  { id: 3, nombre: 'Cecinas Don Pedro', comuna: 'San Carlos', rubro: 'Chacutería', descripcion: 'Elaboración artesanal de embutidos con recetas tradicionales sancarlinas.' },
  { id: 4, nombre: 'Alfareras de Quinchamalí', comuna: 'Chillán', rubro: 'Artesanía en Greda', descripcion: 'Agrupación de artesanas dedicadas al modelado en greda negra, patrimonio de la región.' }
])
</script>

<template>
  <main class="page-container">
    <h2>Nuestros Productores Participantes</h2>
    <p class="intro-p">Conoce a las personas y agrupaciones que dan vida a la identidad productiva de Ñuble.</p>

    <div class="grid-productores">
      <div v-for="p in listaProductores" :key="p.id" class="card-productor">
        <div class="badge-comuna">{{ p.comuna }}</div>
        <h3>{{ p.nombre }}</h3>
        <span class="rubro-tag">{{ p.rubro }}</span>
        <p>{{ p.descripcion }}</p>
      </div>
    </div>
  </main>
</template>

<style scoped>
.page-container {
  padding: 2rem 1rem;
  max-width: 1100px;
  margin: 0 auto;
}
.intro-p {
  color: #555;
  margin-bottom: 2rem;
}
.grid-productores {
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(260px, 1fr));
  gap: 1.5rem;
}
.card-productor {
  background: white;
  border: 1px solid #e2e8f0;
  border-radius: 8px;
  padding: 1.5rem;
  position: relative;
  box-shadow: 0 2px 4px rgba(0,0,0,0.03);
}
.badge-comuna {
  display: inline-block;
  background-color: #2d6a4f;
  color: white;
  font-size: 0.75rem;
  font-weight: bold;
  padding: 0.2rem 0.6rem;
  border-radius: 10px;
  margin-bottom: 0.8rem;
}
.card-productor h3 {
  margin: 0 0 0.4rem 0;
  color: #1b4332;
}
.rubro-tag {
  color: #52b788;
  font-weight: bold;
  font-size: 0.85rem;
}
.card-productor p {
  color: #4a5568;
  font-size: 0.95rem;
  line-height: 1.4;
  margin-top: 0.8rem;
}
</style>