# Proyecto Empresa de Servicios (Actividad 8 y 9)

**Estudiante:** [Tu Nombre]
**Empresa:** TechServices Solutions (Rubro: Servicios Tecnológicos)

## Parte 1 y 2 – Preparación del backend
Se utilizó `mkdir backend` y `npm init -y` para inicializar el proyecto de Node.js. Se instaló `express` como framework web principal.

## Parte 3 y 4 – Primer servidor
Se creó `server.js`. `app.get()` define las rutas, `req` maneja la solicitud, `res` entrega la respuesta y `app.listen()` levanta el servidor en el puerto 3000.

## Parte 5 – Datos de servicios
Se estructuraron 8 servicios en `backend/data/servicios.js` exportados con `module.exports`.

## Parte 6 – API de servicios
Se implementó `res.json()` para retornar los servicios en formato estructurado intercambiable.

## Parte 7 – Consulta por ID
Uso de `req.params.id` convertido con `Number()` para obtener un elemento único y manejar estados 404.

## Parte 8 – Filtro por categoría
Uso de `req.query.categoria` para filtrados opcionales.

## Parte 9 – Middleware JSON
Se incorporó `app.use(express.json())` para interpretar cuerpos JSON en peticiones futuras (POST/PUT).

## Parte 12 – Pruebas finales
1. `GET /`: Servidor en ejecución.
2. `GET /api/servicios`: Devuelve arreglo de 8 servicios.
3. `GET /api/servicios/1`: Retorna el servicio con ID 1.
4. `GET /api/servicios/999`: Lanza error 404 "Servicio no encontrado".
5. `GET /api/servicios?categoria=Soporte`: Filtra correctamente por categoría.

## Instrucciones de ejecución
- **Frontend:** Entrar a `/frontend`, ejecutar `npm install` y `npm run dev`.
- **Backend:** Entrar a `/backend`, ejecutar `node server.js`.