<script setup>
import { ref } from 'vue'
import { useRecepcionStore } from '../stores/useRecepcionStore.js'

const { state } = useRecepcionStore()

const form = ref({ isbn: '', titulo: '', editorial: '', nivel: 'Básica', anio_publicacion: 2025 })

function guardar(){
  const len = form.value.isbn.trim().length
  if(len < 10 || len > 13){ 
    alert('ISBN inválido')
    return
  }
  // BUG: guardar con campo 'anio_publicacion' cuando en estado inicial hay 'anio'
  state.libros.push({ id: Date.now(), ...form.value }) // BUG: inconsistencia de nombre de campo
  form.value = { isbn: '', titulo: '', editorial: '', nivel: 'Básica', anio_publicacion: 2025 }
}
</script>

<template>
  <div>
    <h2>Libros</h2>
    <form @submit.prevent="guardar">
      <input v-model="form.isbn" placeholder="ISBN" />
      <input v-model="form.titulo" placeholder="Título" />
      <input v-model="form.editorial" placeholder="Editorial" />
      <select v-model="form.nivel">
        <option>Básica</option>
        <option>Media</option>
      </select>
      <input v-model.number="form.anio_publicacion" type="number" placeholder="Año" />
      <button type="submit">Agregar</button>
    </form>

    <ul>
      <li v-for="l in state?.libros || []" :key="l.id">{{ l.titulo }} - {{ l.isbn }} - {{ l.anio }} - {{ l.anio_publicacion }}</li>
    </ul>
  </div>
</template>
