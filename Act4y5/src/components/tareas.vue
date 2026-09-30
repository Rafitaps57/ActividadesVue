<template>
  <div class="contenedor-principal">
    <div class="formulario">
      <input v-model="nuevaTarea" placeholder="Escribe una nueva tarea" @keyup.enter="agregarTarea" />
      <button @click="agregarTarea">Agregar</button>
      <button @click="mostrar = !mostrar">
        {{ mostrar ? 'Ocultar' : 'Mostrar' }} Tareas
      </button>
    </div>

    <!-- Lista de tareas (se eliminó la etiqueta <p> duplicada) -->
    <ul v-if="mostrar && tareas.length > 0" class="lista-tareas">
      <li v-for="(t, index) in tareas" :key="index">
        {{ t }}
      </li>
    </ul>

    <p v-if="tareas.length === 0" class="mensaje-vacio">No hay tareas registradas</p>
  </div>
</template>

<script>
export default {
  data() {
    return {
      nuevaTarea: '',
      tareas: [],
      mostrar: true
    }
  },
  methods: {
    agregarTarea() {
      if (this.nuevaTarea.trim() !== '') {
        this.tareas.push(this.nuevaTarea.trim());
        this.nuevaTarea = '';
      }
    }
  }
}
</script>

<style scoped>
.contenedor-principal {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  width: 100%;
  max-width: 500px;
  margin: 0 auto;
  padding: 20px;
  box-sizing: border-box;
}

.formulario {
  display: flex;
  gap: 8px;
  margin-bottom: 20px;
  justify-content: center;
  width: 100%;
}

.lista-tareas {
  list-style-position: inside; /* Mantiene los viñetas alineadas con el texto centrado */
  padding: 0;
  margin: 0;
  width: 100%;
  text-align: center;
}

.lista-tareas li {
  padding: 8px 0;
}

.mensaje-vacio {
  text-align: center;
  color: #888;
}
</style>