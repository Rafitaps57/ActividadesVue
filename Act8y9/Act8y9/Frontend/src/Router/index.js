import { createRouter, createWebHistory } from 'vue-router'
import Inicio from '../views/inicio.vue'
import Nosotros from '../views/nosotros.vue'
import Servicios from '../views/servicios.vue'
import Contacto from '../views/contacto.vue'

const routes = [
  { path: '/', name: 'Inicio', component: Inicio },
  { path: '/nosotros', name: 'Nosotros', component: Nosotros },
  { path: '/servicios', name: 'Servicios', component: Servicios },
  { path: '/contacto', name: 'Contacto', component: Contacto },
  { path: '/:pathMatch(.*)*', redirect: '/' } // Redirige a inicio si la ruta no existe
]

const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router