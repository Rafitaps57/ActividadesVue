<template>
  <header class="navbar-header">
    <div class="navbar-container">
      <div class="brand">
        <span class="brand-title">Turismo Chillán</span>
        <span class="brand-subtitle">Digital</span>
      </div>
      <nav class="nav-links">
        <router-link to="/">Inicio</router-link>
        <router-link to="/atractivos">Atractivos</router-link>
        <router-link to="/gastronomia">Gastronomía</router-link>
        <router-link to="/contacto">Contacto</router-link>
      </nav>
    </div>
  </header>
</template>

<style scoped>
.navbar-header {
  background-color: var(--primary-color);
  box-shadow: 0 2px 4px rgba(0,0,0,0.1);
}

.navbar-container {
  max-width: 1100px;
  margin: 0 auto;
  padding: 1rem;
  display: flex;
  justify-content: space-between;
  align-items: center;
}

.brand-title {
  font-size: 1.3rem;
  font-weight: bold;
  color: #ffffff;
}

.brand-subtitle {
  font-size: 0.9rem;
  color: #fcd34d;
  margin-left: 0.3rem;
}

.nav-links {
  display: flex;
  gap: 1.2rem;
}

.nav-links a {
  color: #f1f5f9;
  text-decoration: none;
  font-weight: 500;
  padding: 0.4rem 0.8rem;
  border-radius: 4px;
  transition: background-color 0.2s;
}

.nav-links a:hover {
  background-color: rgba(255, 255, 255, 0.15);
}

.router-link-active {
  background-color: rgba(255, 255, 255, 0.25);
  font-weight: bold;
}
</style>