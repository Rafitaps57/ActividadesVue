<template>
  <div class="form-container">
    <form @submit.prevent="validarFormulario">
      <input v-model="nombre" placeholder="Nombre" />
      <input v-model="correo" placeholder="Correo electrónico" />
      <input v-model="telefono" placeholder="Teléfono" />
      <textarea v-model="mensaje" placeholder="Mensaje"></textarea>
      
      <label>
        <input type="checkbox" v-model="newsletter" />
        Suscribirse al boletín
      </label>

      <button type="submit">Enviar</button> 
    </form>

    <div v-if="error" class="error-msg">{{ error }}</div>

    <div v-if="enviado" class="success-msg">
      <h3>Datos enviados:</h3>
      <p><strong>Nombre:</strong> {{ nombre }}</p>
      <p><strong>Correo:</strong> {{ correo }}</p>
      <p><strong>Teléfono:</strong> {{ telefono }}</p>
      <p><strong>Mensaje:</strong> {{ mensaje }}</p>
      <p><strong>Boletín:</strong> {{ newsletter ? 'Sí' : 'No' }}</p>
    </div>
  </div>
</template>

<script>
export default {
  name: 'Contacto',
  data() {
    return {
      nombre: '',
      correo: '',
      telefono: '',
      mensaje: '',
      newsletter: false,
      error: '',
      enviado: false
    }
  },
  methods: {
    validarFormulario() {
      if (!this.nombre || !this.correo || !this.telefono || !this.mensaje) {
        this.error = 'Todos los campos son obligatorios';
        this.enviado = false;
        return;
      }
      this.enviado = true;
      this.error = '';
    }
  }
}
</script>

<style scoped>
.form-container {
  max-width: 450px;
  margin: 2rem auto;
  font-family: Arial, sans-serif;
}

form {
  display: flex;
  flex-direction: column;
  gap: 1rem;
  padding: 1.5rem;
  background-color: #f9fafb;
  border-radius: 8px;
  box-shadow: 0 2px 8px rgba(0,0,0,0.1);
}

input[type="text"],
input:not([type="checkbox"]),
textarea {
  width: 100%;
  padding: 0.6rem;
  border: 1px solid #ccc;
  border-radius: 4px;
  box-sizing: border-box;
}

textarea {
  min-height: 80px;
  resize: vertical;
}

label {
  display: flex;
  align-items: center;
  gap: 0.5rem;
  cursor: pointer;
}

button {
  padding: 0.7rem;
  background-color: #2563eb;
  color: white;
  border: none;
  border-radius: 4px;
  font-weight: bold;
  cursor: pointer;
}

button:hover {
  background-color: #1d4ed8;
}

.error-msg {
  margin-top: 1rem;
  padding: 0.8rem;
  background-color: #fee2e2;
  color: #dc2626;
  border-radius: 4px;
  text-align: center;
}

.success-msg {
  margin-top: 1rem;
  padding: 1rem;
  background-color: #d1fae5;
  color: #065f46;
  border-radius: 4px;
}
</style>

