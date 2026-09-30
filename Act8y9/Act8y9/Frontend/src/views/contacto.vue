<template>
  <div class="vista">
    <h1>Contacto y Solicitud</h1>

    <div v-if="enviado" class="exito">
      <h3>¡Solicitud enviada con éxito!</h3>
      <p><strong>Nombre:</strong> {{ form.nombre }}</p>
      <p><strong>Correo:</strong> {{ form.correo }}</p>
      <p><strong>Servicio:</strong> {{ form.servicioInteres }}</p>
      <p><strong>Mensaje:</strong> {{ form.mensaje }}</p>
      <button @click="resetear">Enviar otra consulta</button>
    </div>

    <form v-else @submit.prevent="procesarFormulario">
      <div v-if="error" class="error">{{ error }}</div>

      <div class="campo">
        <label>Nombre completo *</label>
        <input v-model="form.nombre" type="text" />
      </div>

      <div class="campo">
        <label>Correo electrónico *</label>
        <input v-model="form.correo" type="email" />
      </div>

      <div class="campo">
        <label>Teléfono</label>
        <input v-model="form.telefono" type="tel" />
      </div>

      <div class="campo">
        <label>Servicio de interés *</label>
        <input v-model="form.servicioInteres" type="text" placeholder="Ej. Soporte computacional" />
      </div>

      <div class="campo">
        <label>Mensaje *</label>
        <textarea v-model="form.mensaje" rows="4"></textarea>
      </div>

      <button type="submit" class="btn-enviar">Enviar consulta</button>
    </form>
  </div>
</template>

<script>
export default {
  name: 'ContactoView',
  data() {
    return {
      form: {
        nombre: '',
        correo: '',
        telefono: '',
        servicioInteres: '',
        mensaje: ''
      },
      error: '',
      enviado: false
    }
  },
  mounted() {
    // Lee el parámetro de URL si el usuario seleccionó un servicio desde la vista Servicios
    if (this.$route.query.servicio) {
      this.form.servicioInteres = this.$route.query.servicio
    }
  },
  methods: {
    procesarFormulario() {
      if (!this.form.nombre || !this.form.correo || !this.form.servicioInteres || !this.form.mensaje) {
        this.error = 'Por favor complete todos los campos obligatorios (*).'
        return
      }
      this.error = ''
      this.enviado = true
    },
    resetear() {
      this.enviado = false
      this.form = { nombre: '', correo: '', telefono: '', servicioInteres: '', mensaje: '' }
    }
  }
}
</script>

<style scoped>
form { max-width: 500px; margin: 0 auto; }
.campo { margin-bottom: 15px; display: flex; flex-direction: column; }
.campo input, .campo textarea { padding: 8px; border: 1px solid #ccc; border-radius: 4px; }
.error { color: red; margin-bottom: 10px; font-weight: bold; }
.exito { background: #e8f5e9; padding: 20px; border-radius: 8px; }
.btn-enviar { background: #42b983; color: white; border: none; padding: 10px 15px; border-radius: 4px; cursor: pointer; }
</style>