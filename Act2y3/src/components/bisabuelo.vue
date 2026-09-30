<template>
    <div>
        <h1>Componente Bisabuelo</h1>
        <Padre mensaje="Hola desde el bisabuelo"/>
    </div>
</template>

<script>
import Padre from './Padre.vue'
export default {
      name: 'Bisabuelo',
    components: {
        Padre
    }
}
</script>
