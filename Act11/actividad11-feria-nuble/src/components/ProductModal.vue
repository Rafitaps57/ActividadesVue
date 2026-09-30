<script setup>
    import { onMounted, onBeforeUnmount} from 'vue'

const props = defineProps({
    producto: {
        type: Object,
        default : null
    },
    visible: {
        type: Boolean,
        required: true
    }
})

const emit = defineEmits(['close'])

function onKeyDown(event) {
    if (props.visible && event.key === 'Escape') 
        emit('close')
}

onMounted(() => {
    window.addEventListener('keydown', onKeyDown)
})

onBeforeUnmount(() => {
    window.removeEventListener('keydown', onKeyDown)
})

</script>

<template>
    <div v-if="visible && producto" class="overlay" @click.self="$emit('close')">
        <section class="modal" role="dialog" aria-modal="true">
            <header class="modal__header">
                <div>
                    <small>{{ producto.categoria }}</small>
                    <h2>{{ producto.nombre }}</h2>
                </div>
                <button class="modal_close" @click="emit('close')" aria-label="cerrar">
                    x
                </button>
            </header>

            <img class="modal__img" :src="producto.imagen" :alt="producto.nombre" loading="lazy" />

            <div class="modal__content">
                <p>{{ producto.descripcion }}</p>
                <p class="modal__price">
                Precio: {{ new Intl.NumberFormat('es-CL', {
                    style: 'currency',
                    currency: 'CLP',
                    maximumFractionDigits: 0
                }).format(producto.precio) }}
                </p>
            </div>

        </section>
    </div>
</template>

<style scoped>
.overlay {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background-color: rgba(0, 0, 0, 0.5);
    display: flex;
    justify-content: center;
    align-items: center;
    z-index: 9999;
}

.modal {
    background-color: #fff;
    border-radius: 8px;
    max-width: 600px;
    width: 90%;
    padding: 20px;
    box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
    position: relative;
}

.modal__header {
    display: flex;
    justify-content: space-between;
    align-items: center;
    margin-bottom: 20px;
}
 

.modal__header h2 {
    margin: 0;
    font-size: 1.5rem;
}
.modal__header small {
    font-size: 0.9rem;
    color: #666;
}

.modal__close {
    background: none;
    border: none;
    font-size: 1.5rem;
    cursor: pointer;
}

.modal__img {
    width: 100%;
    height: auto;
    margin-bottom: 20px;
}
.modal__content p {
    margin: 0 0 10px;
    line-height: 1.5;
}
.modal__content .modal__price {
    font-weight: bold;
    font-size: 1.2rem;
}
</style>