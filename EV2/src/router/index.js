import { createRouter, createWebHistory } from 'vue-router'
import InicioView from '../views/inicio.vue'
import ProductoDetalleView from '../views/detalleservicio.vue'
import FavoritosView from '../views/favoritos.vue'
import ContactoView from '../views/contacto.vue'
import NotFoundView from '../views/notfound.vue'
import serviciosView from '../views/servicios.vue'

const routes = [
{ path: '/', name: 'inicio', component: InicioView },
{ path: '/servicios', name: 'servicios', component: serviciosView },
{ path: '/servicios/:id', name: 'servicio-detalle', component: ProductoDetalleView },
{ path: '/favoritos', name: 'favoritos', component: FavoritosView },
{ path: '/contacto', name: 'contacto', component: ContactoView },
{ path: '/:pathMatch(.*)*', name: 'not-found', component: NotFoundView }
]
const router = createRouter({
history: createWebHistory(),
routes
})
export default router