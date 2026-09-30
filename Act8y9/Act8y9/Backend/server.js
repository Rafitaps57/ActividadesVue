// backend/server.js
const express = require('express')
const servicios = require('./data/servicios')

const app = express()
const PORT = 3000

// Middleware para interpretar JSON en futuras solicitudes (Parte 9)
app.use(express.json())

// Ruta Principal
app.get('/', (req, res) => {
  res.send('Servidor de empresa funcionando correctamente')
})

// Parte 6 y Parte 8: Obtener todos los servicios O filtrar por categoría (?categoria=...)
app.get('/api/servicios', (req, res) => {
  const categoria = req.query.categoria
  if (categoria) {
    const resultado = servicios.filter(
      servicio => servicio.categoria.toLowerCase() === categoria.toLowerCase()
    )
    return res.json(resultado)
  }
  res.json(servicios)
})

// Parte 7: Consultar servicio por ID (/api/servicios/1)
app.get('/api/servicios/:id', (req, res) => {
  const id = Number(req.params.id)
  const servicio = servicios.find(item => item.id === id)

  if (!servicio) {
    return res.status(404).json({
      mensaje: 'Servicio no encontrado'
    })
  }

  res.json(servicio)
})

// Iniciar Servidor
app.listen(PORT, () => {
  console.log(`Servidor ejecutándose en http://localhost:${PORT}`)
})