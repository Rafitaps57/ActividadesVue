<script setup>
import { reactive, ref } from 'vue'

const form = reactive({
  nombre: '',
  email: '',
  mensaje: ''
})

const enviado = ref(false)
const enviando = ref(false)

const handleSubmit = () => {
  enviando.value = true
  
  setTimeout(() => {
    enviando.value = false
    enviado.value = true
    
    form.nombre = ''
    form.email = ''
    form.mensaje = ''
  }, 800)
}

const reiniciarFormulario = () => {
  enviado.value = false
}
</script>

<template>
  <div class="contacto-wrapper">
    <div class="header-contacto">
      <h1 class="page-title">Oficina de Contacto</h1>
      <p class="page-subtitle">
        ¿Tienes dudas sobre los servicios o deseas más información sobre los talleres de Ñuble? Escríbenos.
      </p>
    </div>

    <div class="card-contacto">
      <div v-if="enviado" class="mensaje-exito">
        <div class="icono-exito">✓</div>
        <h2>¡Consulta Enviada!</h2>
        <p>
          Muchas gracias por escribirnos. La Oficina de Turismo se pondrá en contacto contigo a la brevedad.
        </p>
        <button class="btn-primary" @click="reiniciarFormulario">
          Enviar otra consulta
        </button>
      </div>

      <form v-else class="contact-form" @submit.prevent="handleSubmit">
        <div class="form-group">
          <label for="nombre">Nombre Completo</label>
          <input 
            id="nombre" 
            v-model="form.nombre" 
            type="text" 
            required 
            placeholder="Ej: Juan Pérez" 
          />
        </div>

        <div class="form-group">
          <label for="email">Correo Electrónico</label>
          <input 
            id="email" 
            v-model="form.email" 
            type="email" 
            required 
            placeholder="correo@ejemplo.com" 
          />
        </div>

        <div class="form-group">
          <label for="mensaje">Mensaje o Consulta</label>
          <textarea 
            id="mensaje" 
            v-model="form.mensaje" 
            rows="5" 
            required 
            placeholder="Escribe tu consulta detallada sobre el servicio..."
          ></textarea>
        </div>

        <button type="submit" class="btn-submit" :disabled="enviando">
          <span v-if="!enviando">Enviar Consulta ➔</span>
          <span v-else>Enviando...</span>
        </button>
      </form>
    </div>
  </div>
</template>

<style scoped>
.contacto-wrapper {
  max-width: 600px;
  margin: 0 auto;
}

.header-contacto {
  text-align: center;
  margin-bottom: 2rem;
}

.page-title {
  font-size: 2rem;
  font-weight: 800;
  color: var(--text-main);
  margin-bottom: 0.5rem;
}

.page-subtitle {
  color: var(--text-muted);
  font-size: 1.05rem;
  line-height: 1.5;
}

.card-contacto {
  background: var(--bg-card);
  padding: 2.5rem;
  border-radius: var(--radius-md);
  border: 1px solid var(--border-color);
  box-shadow: var(--shadow-md);
}

.form-group {
  margin-bottom: 1.5rem;
}

label {
  display: block;
  font-size: 0.9rem;
  font-weight: 700;
  margin-bottom: 0.5rem;
  color: var(--text-main);
}

input, 
textarea {
  width: 100%;
  padding: 0.8rem 1rem;
  border: 1px solid var(--border-color);
  border-radius: var(--radius-sm);
  font-size: 0.95rem;
  font-family: inherit;
  background-color: #f8fafc;
  color: var(--text-main);
  transition: all 0.2s ease;
}

input:focus, 
textarea:focus {
  outline: none;
  background-color: #ffffff;
  border-color: var(--primary);
  box-shadow: 0 0 0 3px rgba(37, 99, 235, 0.15);
}

textarea {
  resize: vertical;
}


.btn-submit {
  width: 100%;
  background-color: var(--primary);
  color: white;
  border: none;
  padding: 0.9rem;
  border-radius: var(--radius-sm);
  font-size: 1rem;
  font-weight: 700;
  cursor: pointer;
  transition: background-color 0.2s ease, transform 0.1s ease;
}

.btn-submit:hover:not(:disabled) {
  background-color: var(--primary-hover);
  transform: translateY(-1px);
}

.btn-submit:disabled {
  opacity: 0.7;
  cursor: not-allowed;
}


.mensaje-exito {
  text-align: center;
  padding: 1rem 0;
}

.icono-exito {
  width: 60px;
  height: 60px;
  background-color: #dcfce7;
  color: var(--success);
  font-size: 2rem;
  font-weight: bold;
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
  margin: 0 auto 1.5rem auto;
}

.mensaje-exito h2 {
  font-size: 1.5rem;
  color: var(--text-main);
  margin-bottom: 0.5rem;
}

.mensaje-exito p {
  color: var(--text-muted);
  margin-bottom: 1.5rem;
  line-height: 1.5;
}

.btn-primary {
  background-color: var(--primary);
  color: white;
  border: none;
  padding: 0.75rem 1.5rem;
  border-radius: var(--radius-sm);
  font-weight: 600;
  cursor: pointer;
  transition: background-color 0.2s ease;
}

.btn-primary:hover {
  background-color: var(--primary-hover);
}

@media (max-width: 640px) {
  .card-contacto {
    padding: 1.5rem;
  }
}
</style>