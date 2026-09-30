<template>
  <div id="app">
    <!-- Componente de la barra de navegación -->
    <Navbar />

    <!-- Aquí Vue Router renderiza la vista activa según la URL -->
    <main class="main-content">
      <router-view />
    </main>
  </div>
</template>

<script setup>
import Navbar from './components/navbar.vue'
</script>

<style>
@import './assets/main.css';
</style>

