<script setup>
import { computed } from 'vue'

const props = defineProps({
  producto: {
    type: Object,
    required: true
  }
})

const emit = defineEmits(['ver-detalle'])

const precioCLP = computed(() => {
  new Intl.NumberFormat('es-CL', {
    style: 'currency',
    currency: 'CLP',
    maximumFractionDigits: 0
  }).format(props.producto.precio)
})
</script>

<template>
    <article class="card">
        <img class="card_img"
            :src="props.producto.imagen"
            :alt="props.producto.nombre"
            loading="lazy"
        />
        <div class="card_body">
            <span class="card_cat">{{ props.producto.categoria }}</span>
            <h3 class="card_title">{{ props.producto.nombre }}</h3>
            <p class="card_price">{{ precioCLP }}</p>

            <button class="card_btn" @click="$emit('ver-detalle', props.producto)">Ver detalle</button>
        </div>
    </article>
</template>

<style scoped>
.card {
    display: flex;
    flex-direction: column;
    border-radius: 0.5rem;
    box-shadow: 0 0.5rem 1rem rgba(0, 0, 0, 0.1);
    overflow: hidden;
    transition: transform 0.3s ease-in-out;
}
.card.hover {
    transform: translateY(-4px);
    box-shadow: 0 12px 28px rgba(15, 23, 42, 0.12);
}
.card_img {
    width: 100%;
    height: 100%;
    object-fit: cover;
}
.card_body {
    padding: 16px;
    display: flex;
    flex-direction: column;
}
.card_cat {
    font-size: .78rem;
    color: #1d4ed8;
    align-self: flex-start;
    padding: 4px 9px;
    border-radius: 999px;
    background: #eff6ff;
    font-weight: 700; 
}
.card_title {
    font-size: 1.08rem;
    margin: 10px 0 6px;
}
.card_price {
    font-size: 1.05rem;
    font-weight: 800;
    margin: auto 0 14px;
}
.card_btn {
    background: #1d4ed8;
    color: #fff;
    font-size: 0.9rem;
    font-weight: 700;
    padding: 10px 16px;
    border-radius: 0.5rem;
    transition: all 0.3s ease-in-out;
}
.card_btn:hover {
    background: #1e40af;
}
</style>