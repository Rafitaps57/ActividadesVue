<script setup>
import { RouterView } from 'vue-router'
import Navbar from './components/Navbar.vue'
</script>

<template>
  <div id="app" class="page">
    <Navbar />

    <header class="hero">
      <div>
        <p class="eyebrow">Evaluación N° 2 · Vue.js · Ingeniería Web</p>
        <h1>Servicios del Ñuble</h1>
        <p class="hero__text">
          Explora los servicios producidos por emprendedores locales.
        </p>
      </div>
    </header>

    <main class="contenido-principal">
      <RouterView />
    </main>

    <footer class="footer">
      <p>Servicios del Ñuble ·  EV2 Ingeniería Web</p>
    </footer>
  </div>
</template>

<style scoped>
.page { 
  max-width: 1120px; 
  margin: 0 auto; 
  padding: 20px 20px 40px; 
  display: flex;
  flex-direction: column;
  min-height: 100vh;
}

.contenido-principal {
  flex: 1;
  margin-top: 20px;
}

.hero {
  margin-top: 15px;
  margin-bottom: 20px;
  padding: 32px;
  border-radius: 22px;
  color: white;
  background: linear-gradient(135deg, #0f3f76, #1d4ed8);
}

.eyebrow { 
  margin: 0 0 8px; 
  font-size: .8rem; 
  font-weight: 800; 
  text-transform: uppercase; 
  letter-spacing: .08em; 
  opacity: .85; 
}

.hero h1 { 
  margin: 0; 
  font-size: clamp(2rem, 5vw, 3.3rem); 
}

.hero__text { 
  max-width: 760px; 
  margin: 12px 0 0; 
  line-height: 1.6; 
  opacity: .92; 
}

.footer { 
  margin-top: 30px; 
  padding-top: 18px; 
  border-top: 1px solid #e2e8f0; 
  color: #64748b; 
  font-size: .85rem; 
  text-align: center; 
}
</style>