<script setup lang="ts">
const props = defineProps<{
  title?: string
  imageSrc?: string
  diaObra?: string
  obraId: number
  genero?: string
}>()

import { useSeatStore } from '@/stores/SeatStore';
import { ref, onMounted } from 'vue';

const freeSeatsCount = ref(0);
const SeatStore = useSeatStore();

onMounted(async () => {
  try {
    await SeatStore.fetchSeatsPerId(props.obraId);
    freeSeatsCount.value = SeatStore.freeSeatsPerId;
  } catch (error) {
    console.error('Error al hacer fetch en las butacas:', error);
  }
});






</script>

<template>
  <RouterLink :to="'/Obra/' + obraId">
    <div class="imgContainer">
      <img :src="'src/assets/IMAGENES/' + imageSrc" alt="title">
    </div>
    <div class="card__description">
      <h2>{{ title }}</h2>
      <h3>{{ genero }}</h3>
      <h3 class="freeSeatsCount">Butacas disponibles: {{ freeSeatsCount }}</h3>
    </div>
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

.imgContainer {

  height: 65%;
  margin-top: 5%;

  img {
    width: 90%;
    height: 100%;
    border-radius: 15px;

  }
}

.card__description {

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

  .freeSeatsCount {
      font: {
        size: 12px;
      }
    }
}



/* PARA ORDENADORES */
@media screen and (min-width: 1056px) {

  .card__description {

    h2 {
      font: {
        size: 36px;
      }
    }

    h3 {
      font: {
        size: 24px;
      }
    }

    .freeSeatsCount {
      font: {
        size: 18px;
      }
    }


  }

}
</style>