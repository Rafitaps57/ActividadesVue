// backend/data/servicios.js
const servicios = [
  {
    id: 1,
    nombre: 'Desarrollo de sitios web',
    categoria: 'Desarrollo',
    descripcion: 'Creación de sitios web para empresas y emprendimientos.',
    precio: 250000,
    disponible: true
  },
  {
    id: 2,
    nombre: 'Soporte computacional',
    categoria: 'Soporte',
    descripcion: 'Diagnóstico y configuración de equipos computacionales.',
    precio: 35000,
    disponible: true
  },
  {
    id: 3,
    nombre: 'Instalación de redes',
    categoria: 'Infraestructura',
    descripcion: 'Instalación y configuración de redes para oficinas.',
    precio: 180000,
    disponible: false
  },
  {
    id: 4,
    nombre: 'Asesoría tecnológica',
    categoria: 'Consultoría',
    descripcion: 'Apoyo en decisiones tecnológicas para pequeñas empresas.',
    precio: 70000,
    disponible: true
  },
  {
    id: 5,
    nombre: 'Mantención de equipos',
    categoria: 'Soporte',
    descripcion: 'Mantención preventiva de computadores y notebooks.',
    precio: 30000,
    disponible: true
  },
  {
    id: 6,
    nombre: 'Configuración WiFi empresarial',
    categoria: 'Infraestructura',
    descripcion: 'Configuración y optimización de redes inalámbricas.',
    precio: 90000,
    disponible: false
  },
  // Servicios adicionales exigidos por la pauta (Punto 11)
  {
    id: 7,
    nombre: 'Auditoría de Ciberseguridad',
    categoria: 'Ciberseguridad', // Categoría propia
    descripcion: 'Análisis de vulnerabilidades e implementación de cortafuegos.',
    precio: 320000,
    disponible: true
  },
  {
    id: 8,
    nombre: 'Migración a la Nube',
    categoria: 'Ciberseguridad',
    descripcion: 'Respaldo y configuración de servidores en AWS/Azure.',
    precio: 210000,
    disponible: true
  }
]

module.exports = servicios