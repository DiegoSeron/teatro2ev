<script setup lang="ts">
defineProps<{
  title?: string
  imageSrc?: string
  diaObra?: string
  obraId: number
  genero: string
}>()

</script>

<template>
  <RouterLink :to="'/Obra/' + obraId">
    <article class="card">
      <div class="imgContainer">
        <img :src="'src/assets/IMAGENES/' + imageSrc" alt="title">
      </div>
      <div class="card__description">
        <h2>{{ title }}</h2>
        <h3>{{ obraId }}</h3>
        <h3>{{ genero }}</h3>
      </div>
    </article>
  </RouterLink>
</template>

<style scoped lang="scss">
@import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@400;700&display=swap');
@import url('https://fonts.googleapis.com/css2?family=Bebas+Neue&display=swap');

$primaryColor: #ba1313;
$primaryFont: 'Bebas Neue';
$secondlyFont: 'Montserrat';

a {
  text-decoration: none;
}

.card {
  background-color: $primaryColor;
  width: auto;
  height: auto;
  margin: 10px;
  flex-basis: calc(50% - 20px);
  border-radius: 15px 15px 5px 5px;
  transition: all 300ms ease;
  cursor: pointer;

  .imgContainer {

    height: 65%;
    margin-top: 5%;

    img {
      width: 90%;
      height: 100%;
      border-radius: 15px;

    }
  }

  &__description {

    height: auto;
    color: white;
    text-align: left;

    h2 {
      margin: {
        top: 5%;
        bottom: 0;
        left: 6%;
        right: 6%;
      }

      font-family: $primaryFont;
    }

    h3 {
      margin: {
        top: 0;
        bottom: 5%;
        left: 6%;
      }

      font-family: $secondlyFont;
    }
  }

  .card:hover {
    transform: scale(1.05);

}

  /* PARA ORDENADORES */
  @media screen and (min-width: 767px) {
    flex-basis: calc(33% - 20px);
  }

}

/* PARA ORDENADORES */
@media screen and (min-width: 767px) {

    .card {
        flex-basis: calc(33% - 20px);
    }

}

</style>