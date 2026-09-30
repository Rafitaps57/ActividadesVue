import { createRouter, createWebHistory } from 'vue-router'
import Inicio from '../views/inicio.vue'
import Contacto from '../views/contactos.vue'
import Gastronomia from '../views/gastronomia.vue'
import Atractivos from '../views/atractivos.vue'


const routes = [
  { path: '/', name: 'home', component: Inicio },
  { path: '/contacto', name: 'contacto', component: Contacto },
  { path: '/gastronomia', name: 'gastronomia', component: Gastronomia },
  { path: '/atractivos', name: 'atractivos', component: Atractivos }
]

const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router