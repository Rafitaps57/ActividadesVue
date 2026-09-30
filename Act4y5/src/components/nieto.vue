<template>
    <div>
        <H4>Componente Nieto</H4>
        <p>Mensaje recibido:{{ mensaje }}</p>
    </div>
</template>

<script>
export default {
    name: 'Nieto',
    props: ['mensaje']
}
</script>

