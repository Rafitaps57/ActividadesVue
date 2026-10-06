<template>
  <header class="header">
    <div class="header-container">
      <RouterLink to="/" class="logo">
        <span class="logo-icon">🌿</span>
        <span class="logo-texto">Servicios <strong>Ñuble</strong></span>
      </RouterLink>

      <nav class="nav-links">
        <RouterLink to="/">Inicio</RouterLink>
        <RouterLink to="/servicios">Catálogo</RouterLink>
        <RouterLink to="/favoritos" class="nav-favoritos">
          Favoritos
          <span v-if="favoritosCount > 0" class="badge">{{ favoritosCount }}</span>
        </RouterLink>
        <RouterLink to="/contacto">Contacto</RouterLink>
      </nav>
    </div>
  </header>
</template>

<style scoped>
.header {
  background-color: #0f172a; 
  position: sticky;
  top: 0;
  z-index: 100;
  box-shadow: 0 4px 6px -1px rgba(0, 0, 0, 0.1);
  margin-bottom: 2rem;
}

.header-container {
  max-width: 1200px;
  margin: 0 auto;
  padding: 0.85rem 1.5rem;
  display: flex;
  justify-content: space-between;
  align-items: center;
}


.logo {
  display: flex;
  align-items: center;
  gap: 0.5rem;
  text-decoration: none;
  font-size: 1.25rem;
  color: #ffffff;
}

.logo-icon {
  font-size: 1.4rem;
}

.logo-texto strong {
  color: #3b82f6;
}


.nav-links {
  display: flex;
  align-items: center;
  gap: 1.5rem;
}

.nav-links a {
  color: #94a3b8;
  text-decoration: none;
  font-weight: 600;
  font-size: 0.95rem;
  padding: 0.4rem 0.75rem;
  border-radius: 6px;
  transition: all 0.2s ease-in-out;
}

.nav-links a:hover {
  color: #ffffff;
  background-color: rgba(255, 255, 255, 0.05);
}

.nav-links a.router-link-active {
  color: #ffffff;
  background-color: #2563eb;
}

.nav-favoritos {
  position: relative;
  display: flex;
  align-items: center;
  gap: 0.4rem;
}

.badge {
  background-color: #ef4444;
  color: white;
  font-size: 0.75rem;
  font-weight: 700;
  padding: 0.15rem 0.45rem;
  border-radius: 9999px;
  line-height: 1;
}

@media (max-width: 640px) {
  .header-container {
    flex-direction: column;
    gap: 0.8rem;
    padding: 0.8rem;
  }
  
  .nav-links {
    gap: 0.5rem;
    width: 100%;
    justify-content: center;
  }
  
  .nav-links a {
    font-size: 0.85rem;
    padding: 0.35rem 0.6rem;
  }
}
</style>