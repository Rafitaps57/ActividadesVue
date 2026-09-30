<template>
    <div>
        <h4>Componente Hijo</h4>
        <p v-if="mensaje"> {{ mensaje }}</p>
    </div>
</template>

<script>
export default {
    name: 'Hijo',
    props: ['mensaje']
}
</script>
