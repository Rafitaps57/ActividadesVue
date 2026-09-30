<template>
  <div>
    <h2>Actividad 4</h2>
    <Contacto />
    <hr />
    <h2>Actividad 5</h2>
    <Tareas />
    <Personas />
    <hr />
  </div>
</template>

<script>
import Tareas from './components/Tareas.vue';
import Contacto from './components/contacto.vue';
import Personas from './components/personas.vue';

export default {
  components: { 
    Contacto,
    Tareas,
    Personas
    
  }
}
</script>