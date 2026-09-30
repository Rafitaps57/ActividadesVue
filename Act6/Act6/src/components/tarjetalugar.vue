<template>
  <div class="card">
    <img :src="imagen" :alt="titulo" class="card-img" />
    <div class="card-body">
      <span v-if="categoria" class="card-tag">{{ categoria }}</span>
      <h3 class="card-title">{{ titulo }}</h3>
      <p class="card-desc">{{ descripcion }}</p>
    </div>
  </div>
</template>

<script setup>
defineProps({
  titulo: { type: String, required: true },
  descripcion: { type: String, required: true },
  imagen: { type: String, required: true },
  categoria: { type: String, default: '' }
})
</script>

<style scoped>
.card {
  background: var(--card-bg);
  border-radius: 8px;
  overflow: hidden;
  box-shadow: 0 4px 6px -1px rgba(0, 0, 0, 0.1);
  transition: transform 0.2s;
  display: flex;
  flex-direction: column;
}

.card:hover {
  transform: translateY(-4px);
}

.card-img {
  width: 100%;
  height: 180px;
  object-fit: cover;
}

.card-body {
  padding: 1.2rem;
  display: flex;
  flex-direction: column;
  flex-grow: 1;
}

.card-tag {
  font-size: 0.75rem;
  text-transform: uppercase;
  color: var(--secondary-color);
  font-weight: bold;
  margin-bottom: 0.3rem;
}

.card-title {
  margin: 0 0 0.5rem 0;
  color: var(--primary-color);
}

.card-desc {
  font-size: 0.95rem;
  color: #475569;
  line-height: 1.4;
  margin: 0;
}
</style>