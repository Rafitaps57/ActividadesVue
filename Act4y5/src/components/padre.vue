<template>
  <div>
    <h4>Componente Padre</h4>
    <HijoBoton @saludo="mostrarsaludo" />
    <Hijo :mensaje="mensaje" />
  </div>
</template>

<script>
import HijoBoton from './hijoboton.vue'
import Hijo from './hijo.vue'

export default {
  name: 'Padre',
  components: {
    HijoBoton,
    Hijo
  },
  data() {
    return {
      mensaje: ''
    }
  },
  methods: {
    mostrarsaludo() {
      this.mensaje = '¡Hola desde el hijo!'
    }
  }
}
</script>
