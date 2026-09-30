<template>
  <div class="container">
    <h1 class="page-title">Bienvenidos a Chillán</h1>
    <p class="page-subtitle">Cuna de héroes, tierra de tradiciones y naturaleza libre.</p>

    <div class="hero-box">
      <h2>Historia de la Ciudad</h2>
      <p>
        Fundada originalmente en 1580 por Martín Ruiz de Gamboa bajo el nombre de <em>San Bartolomé de Gamboa</em>, 
        Chillán es una de las ciudades más históricas de Chile. Conocida como la "Cuna de la Patria", en ella nacieron 
        figuras fundamentales como Bernardo O'Higgins, Claudio Arrau, Marta Colvin y Volodia Teitelboim.
      </p>
      <p>
        Tras el terremoto de 1939, la ciudad se reconstruyó incorporando una destacada arquitectura moderna y un 
        espíritu resiliente que hoy combina tradición campesina, gastronomía autóctona y turismo de montaña.
      </p>
    </div>
  </div>
</template>

<style scoped>
.hero-box {
  background: white;
  padding: 2rem;
  border-radius: 8px;
  border-left: 5px solid var(--primary-color);
  box-shadow: 0 2px 4px rgba(0,0,0,0.05);
}

.hero-box h2 {
  color: var(--primary-color);
  margin-top: 0;
}

.hero-box p {
  line-height: 1.6;
  color: #334155;
}
</style>