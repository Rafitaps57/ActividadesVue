<script setup>
import { RouterLink } from 'vue-router'
</script>

<template>
  <div class="inicio-container">
    <section class="hero-section">
      <div class="hero-content">
        <span class="badge-tag">Región de Ñuble</span>
        <h1 class="hero-title">Tradición, Identidad y Artesanía Local</h1>
        <p class="hero-description">
          Descubre talleres, rutas turísticas y servicios tradicionales creados por emprendedores y artesanos de nuestra región.
        </p>
        <div class="hero-buttons">
          <RouterLink to="/servicios" class="btn-primary">
            Explorar Catálogo ➔
          </RouterLink>
          <RouterLink to="/contacto" class="btn-secondary">
            Contáctanos
          </RouterLink>
        </div>
      </div>
    </section>

    <section class="stats-section">
      <div class="stat-card">
        <span class="stat-number">+20</span>
        <span class="stat-label">Artesanos Locales</span>
      </div>
      <div class="stat-card">
        <span class="stat-number">100%</span>
        <span class="stat-label">Auténtico de Ñuble</span>
      </div>
      <div class="stat-card">
        <span class="stat-number">21</span>
        <span class="stat-label">Comunas Representadas</span>
      </div>
    </section>

    <section class="features-section">
      <h2 class="section-title">¿Qué encontrarás en nuestro sitio?</h2>
      
      <div class="features-grid">
        <div class="feature-card">
          <div class="feature-icon">🏺</div>
          <h3>Talleres & Experiencias</h3>
          <p>Aprende alfarería de Quinchamalí, bordado tradicional y más artes ancestrales de la región.</p>
        </div>

        <div class="feature-card">
          <div class="feature-icon">🍷</div>
          <h3>Turismo Patrimonial</h3>
          <p>Recorre los viñedos del Valle del Itata y conoce la historia detrás de nuestras tradiciones.</p>
        </div>

        <div class="feature-card">
          <div class="feature-icon">⭐</div>
          <h3>Guarda tus Favoritos</h3>
          <p>Selecciona los servicios que más te interesen para revisarlos o reservarlos cuando quieras.</p>
        </div>
      </div>
    </section>

    <section class="cta-banner">
      <h2>¿List@ para explorar los servicios?</h2>
      <p>Filtra por categoría o busca por nombre directamente en nuestro catálogo.</p>
      <RouterLink to="/servicios" class="btn-cta">
        Ir al Catálogo de Servicios
      </RouterLink>
    </section>
  </div>
</template>

<style scoped>
.inicio-container {
  display: flex;
  flex-direction: column;
  gap: 3.5rem;
}

.hero-section {
  background: linear-gradient(135deg, #0f172a 0%, #1e3a8a 100%);
  color: white;
  padding: 4rem 2rem;
  border-radius: 20px;
  box-shadow: 0 10px 25px -5px rgba(15, 23, 42, 0.25);
}

.hero-content {
  max-width: 700px;
}

.badge-tag {
  background-color: rgba(59, 130, 246, 0.2);
  color: #93c5fd;
  font-size: 0.85rem;
  font-weight: 700;
  padding: 0.35rem 0.85rem;
  border-radius: 20px;
  border: 1px solid rgba(147, 197, 253, 0.3);
  display: inline-block;
  margin-bottom: 1.25rem;
  text-transform: uppercase;
  letter-spacing: 0.05em;
}

.hero-title {
  font-size: clamp(2.2rem, 4vw, 3.2rem);
  font-weight: 800;
  line-height: 1.2;
  margin-bottom: 1rem;
}

.hero-description {
  font-size: 1.15rem;
  color: #cbd5e1;
  line-height: 1.6;
  margin-bottom: 2rem;
}

.hero-buttons {
  display: flex;
  gap: 1rem;
  flex-wrap: wrap;
}

.btn-primary {
  background-color: #2563eb;
  color: white;
  padding: 0.85rem 1.75rem;
  border-radius: 10px;
  font-weight: 700;
  text-decoration: none;
  transition: all 0.2s ease;
}

.btn-primary:hover {
  background-color: #1d4ed8;
  transform: translateY(-2px);
}

.btn-secondary {
  background-color: rgba(255, 255, 255, 0.1);
  color: white;
  padding: 0.85rem 1.75rem;
  border-radius: 10px;
  font-weight: 600;
  text-decoration: none;
  border: 1px solid rgba(255, 255, 255, 0.2);
  transition: all 0.2s ease;
}

.btn-secondary:hover {
  background-color: rgba(255, 255, 255, 0.2);
}

.stats-section {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
  gap: 1.5rem;
}

.stat-card {
  background-color: white;
  padding: 1.75rem;
  border-radius: 14px;
  border: 1px solid #e2e8f0;
  text-align: center;
  box-shadow: 0 2px 4px rgba(0,0,0,0.02);
}

.stat-number {
  display: block;
  font-size: 2.2rem;
  font-weight: 800;
  color: #2563eb;
}

.stat-label {
  color: #64748b;
  font-weight: 600;
  font-size: 0.95rem;
}

.section-title {
  font-size: 1.8rem;
  font-weight: 800;
  color: #0f172a;
  text-align: center;
  margin-bottom: 2rem;
}

.features-grid {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(260px, 1fr));
  gap: 1.5rem;
}

.feature-card {
  background: white;
  padding: 2rem;
  border-radius: 16px;
  border: 1px solid #e2e8f0;
  box-shadow: 0 4px 6px -1px rgba(0,0,0,0.05);
}

.feature-icon {
  font-size: 2.5rem;
  margin-bottom: 1rem;
}

.feature-card h3 {
  font-size: 1.2rem;
  color: #0f172a;
  margin-bottom: 0.5rem;
}

.feature-card p {
  color: #64748b;
  font-size: 0.95rem;
  line-height: 1.5;
}

.cta-banner {
  background-color: #f1f5f9;
  border: 2px dashed #cbd5e1;
  padding: 3rem 2rem;
  border-radius: 20px;
  text-align: center;
}

.cta-banner h2 {
  font-size: 1.6rem;
  color: #0f172a;
  margin-bottom: 0.5rem;
}

.cta-banner p {
  color: #64748b;
  margin-bottom: 1.5rem;
}

.btn-cta {
  display: inline-block;
  background-color: #0f172a;
  color: white;
  padding: 0.85rem 1.75rem;
  border-radius: 10px;
  font-weight: 700;
  text-decoration: none;
  transition: background-color 0.2s ease;
}

.btn-cta:hover {
  background-color: #1e293b;
}
</style>