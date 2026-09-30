<template>
  <div class="container">
    <h1 class="page-title">Contacto</h1>
    <p class="page-subtitle">¿Dudas sobre tu visita? Escríbenos a la Oficina de Turismo.</p>

    <form class="contact-form" @submit.prevent="handleSubmit">
      <div class="form-group">
        <label for="nombre">Nombre Completo:</label>
        <input id="nombre" v-model="form.nombre" type="text" required placeholder="Ej: Juan Pérez" />
      </div>

      <div class="form-group">
        <label for="email">Correo Electrónico:</label>
        <input id="email" v-model="form.email" type="email" required placeholder="correo@ejemplo.com" />
      </div>

      <div class="form-group">
        <label for="mensaje">Mensaje:</label>
        <textarea id="mensaje" v-model="form.mensaje" rows="4" required placeholder="Escribe tu consulta aquí..."></textarea>
      </div>

      <button type="submit" class="btn-submit">Enviar Consulta</button>
    </form>
  </div>
</template>

<script setup>
import { reactive } from 'vue'

const form = reactive({
  nombre: '',
  email: '',
  mensaje: ''
})

const handleSubmit = () => {
  alert(`¡Gracias por tu mensaje, ${form.nombre}! Nos pondremos en contacto contigo pronto.`)
  form.nombre = ''
  form.email = ''
  form.mensaje = ''
}
</script>

<style scoped>
.contact-form {
  max-width: 500px;
  margin: 0 auto;
  background: white;
  padding: 2rem;
  border-radius: 8px;
  box-shadow: 0 4px 6px -1px rgba(0, 0, 0, 0.1);
}

.form-group {
  margin-bottom: 1.2rem;
}

label {
  display: block;
  font-weight: 600;
  margin-bottom: 0.4rem;
  color: #334155;
}

input, textarea {
  width: 100%;
  padding: 0.6rem;
  border: 1px solid #cbd5e1;
  border-radius: 4px;
  box-sizing: border-box;
  font-family: inherit;
}

input:focus, textarea:focus {
  outline: none;
  border-color: var(--primary-color);
}

.btn-submit {
  width: 100%;
  background-color: var(--primary-color);
  color: white;
  border: none;
  padding: 0.8rem;
  border-radius: 4px;
  font-weight: bold;
  cursor: pointer;
  transition: background-color 0.2s;
}

.btn-submit:hover {
  background-color: #6b0000;
}
</style>