<template>
  <div class="card" :class="{ 'no-disponible': !servicio.disponible }">
    <h3>{{ servicio.nombre }}</h3>
    <p class="categoria"><strong>Categoría:</strong> {{ servicio.categoria }}</p>
    <p>{{ servicio.descripcion }}</p>
    <p class="precio"><strong>Precio:</strong> ${{ servicio.precio.toLocaleString() }}</p>
    
    <span v-if="servicio.disponible" class="badge disponible">Disponible</span>
    <span v-else class="badge agotado">No disponible</span>

    <button 
      v-if="servicio.disponible" 
      @click="$emit('seleccionar', servicio)"
      class="btn-solicitar"
    >
      Solicitar información
    </button>
  </div>
</template>

<script>
export default {
  name: 'ServicioCard',
  props: {
    servicio: {
      type: Object,
      required: true
    }
  }
}
</script>

<style scoped>
.card {
  border: 1px solid #ccc;
  border-radius: 8px;
  padding: 16px;
  margin: 10px;
  background-color: #fff;
  box-shadow: 0 2px 5px rgba(0,0,0,0.1);
}
.no-disponible {
  opacity: 0.6;
}
.categoria {
  color: #555;
  font-size: 0.9em;
}
.precio {
  font-size: 1.1em;
  color: #2c3e50;
}
.badge {
  display: inline-block;
  padding: 4px 8px;
  border-radius: 4px;
  font-size: 0.8em;
  margin-bottom: 10px;
}
.disponible { background: #e8f5e9; color: #2e7d32; }
.agotado { background: #ffebee; color: #c62828; }
.btn-solicitar {
  display: block;
  width: 100%;
  padding: 8px;
  background-color: #42b983;
  color: white;
  border: none;
  border-radius: 4px;
  cursor: pointer;
}
.btn-solicitar:hover {
  background-color: #369f6e;
}
</style>