import imgMiel from '../assets/img/mielquillon.jpg'
import imgQueso from '../assets/img/queso.jpg'
import imgTejidos from '../assets/img/poncholana.jpg'

export const productos = [
  {
    id: 1,
    nombre: "Queso Chanco de San Carlos",
    precio: 4500,
    categoria: "Lácteos",
    imagen: imgQueso,
    descripcion: "Queso Chanco de San Carlos, ideal para acompañar tus comidas.",
},
{
    id: 2,
    nombre: "Miel de Quillon",
    precio: 3500,
    categoria: "miel",
    imagen: imgMiel,
    descripcion: "Miel de Quillon, 100% natural y deliciosa.",
},
{
    id: 3,
    nombre: "Poncho tejido de Coihueco",
    precio: 25000,
    categoria: "textil",
    imagen: imgTejidos,
    descripcion: "Poncho tejido a mano en Coihueco, perfecto para abrigarte en invierno.",
}
]