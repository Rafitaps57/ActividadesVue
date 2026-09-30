<template>
    <div>
        <h2>Componente Padre</h2>
        <Hijo :mensaje="mensaje"/>
    </div>
</template>

<script>
import Hijo from './hijo.vue'
export default {
    name: 'Padre',
    components: {
    
        Hijo
    },
   props: ['mensaje']
}
</script>
