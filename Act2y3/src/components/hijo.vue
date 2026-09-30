<template>
    <div>
        <h4>Componente Hijo</h4>
        <p>Mensaje propio del hijo {{ mensaje }}</p>
        <Nieto :mensaje="mensaje"/>
    </div>
</template>

<script>
import Nieto from './nieto.vue'
export default {
    name: 'Hijo',
    components: {
        Nieto
    },
    props: ['mensaje']
}
</script>
