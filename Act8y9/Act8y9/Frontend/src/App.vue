<!-- src/App.vue -->
<template>
  <div id="app-container">
    <header class="navbar">
      <h2>TechServices</h2>
      <nav>
        <router-link to="/">Inicio</router-link> |
        <router-link to="/nosotros">Nosotros</router-link> |
        <router-link to="/servicios">Servicios</router-link> |
        <router-link to="/contacto">Contacto</router-link>
      </nav>
    </header>

    <main class="contenido">
      <!-- AQUÍ ES DONDE VUE RENDERIZA LAS VISTAS -->
      <router-view />
    </main>
  </div>
</template>