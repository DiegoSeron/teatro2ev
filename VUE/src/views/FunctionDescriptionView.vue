<script setup lang="ts">

import { computed } from 'vue';
import { useRoute } from 'vue-router';
import { useFunctionStore } from '@/stores/FunctionStore';

const FunctionStore = useFunctionStore();
const route = useRoute();
const id = Number.parseInt(route.params.id as string);

const Idfunction = FunctionStore.searchFunctionsPerId(id);

const separatedPlot = computed(() => {
    return Idfunction?.reparto?.split(',');

});


</script>


<template>
    <div class="content">
        <h2>{{ Idfunction?.titulo }}</h2>
        <section class="first">
            <div class="principal">
                <div>
                    <img :src="'../src/assets/IMAGENES/' + Idfunction?.imagen" :alt="`${Idfunction?.titulo}`">
                </div>
                <div>
                    <RouterLink :to="'/Butaca/' + id">SELECCIONAR BUTACAS</RouterLink>

                </div>
            </div>
            <div class="secundary">
                <div class="date">
                    <h3>Horario</h3>
                    <div class="date__data">
                        <!-- Mostrar la fecha -->
                        <h3>Día: {{ FunctionStore.formatoDia(Idfunction?.diaObra.toString() as string) }}</h3>
                        <!-- Mostrar la hora -->
                        <h3>Hora: {{ FunctionStore.formatoHora(Idfunction?.diaObra.toString() as string) }}</h3>
                    </div>
                </div>
                <div class="information">
                    <h3>Información</h3>
                    <div class="information__data">
                        <h3>Género: {{ Idfunction?.genero }}</h3>
                        <h3>Duración: {{ Idfunction?.duracion }} minutos</h3>
                        <h3>Precio: {{ Idfunction?.precio }}€</h3>
                    </div>
                </div>
            </div>

        </section>

        <section>
            <div class="description">

                <h3>Descripcion</h3>
                <div>
                    <p>{{ Idfunction?.descripcion }}</p>
                </div>

            </div>
            <div class="cast">
                <h3>Reparto</h3>
                <div>
                    <ul>
                        <li v-for="actor in separatedPlot">{{ `- ${actor}` }}</li>
                    </ul>
                </div>
            </div>

        </section>

    </div>
</template>
  
<style scoped lang="scss">
@import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@400;700&display=swap');
@import url('https://fonts.googleapis.com/css2?family=Bebas+Neue&display=swap');
@import url('https://fonts.googleapis.com/css?family=Merryweather');


$primaryColor: #ba1313;
$primaryFont: 'Bebas Neue';
$secondFont: 'Montserrat';
$thirdFont: 'Merryweather';

@mixin content($width, $height) {
    width: $width;
    height: $height;

    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;

    padding: {
        top: 16px;
        bottom: 16px;
    }


    h3 {
        font: {
            family: $secondFont;
        }

        color: $primaryColor;
    }
}

@mixin data {
    border: 1px solid gray;
    text-align: left;

    padding: 16px;
    margin: 16px;

    border-radius: 7px;

    h3 {
        font: {
            family: $secondFont;
        }

        color: black;
        padding: 5px;
    }
}

.content {
    width: 100%;
    height: auto;

}

h2 {
    font: {
        family: $primaryFont;
        size: 60px;
    }

    margin: {
        top: 20px;
        bottom: 0;
    }
}



section {
    width: 100%;
    height: auto;

    display: flex;
    flex-direction: column;

    h3 {
        margin: 0;
    }
}


.principal {
    @include content(100%, auto);



    div {
        display: flex;
        flex-direction: column;
        text-align: center;
        justify-content: center;

        img {
            border-radius: 21px;
        }

        a {
            color: $primaryColor;
            text-decoration: none;

            margin-top: 15px;

            font: {
                family: $secondFont;
                size: 18px;
                weight: bold;
            }

            border-radius: 50px;
            border: 3px solid $primaryColor;
            width: 100%;

        }
    }


}

.date {
    @include content(100%, 25%);



    &__data {
        @include data();

    }
}

.information {
    @include content(100%, 25%);

    &__data {
        @include data();
    }
}

.description {
    @include content(100%, 50%);

    div {
        margin: {
            left: 30px;
            right: 30px;
        }

        text-align: left;

        p {
            font: {
                size: 18px;
                family: $thirdFont;
            }

            text-align: justify;

        }
    }



}

.cast {
    @include content(100%, 50%);

    div {
        margin: {
            left: 30px;
            right: 30px;
        }

        text-align: left;

        ul {
            font: {
                size: 18px;
                family: $thirdFont;
            }

            list-style: none;

            text-align: justify;

        }
    }

}




/* PARA ORDENADORES */
@media screen and (min-width: 767px) {

    .first {
        flex-direction: row;
        justify-content: center;
    }

    .principal {
        @include content(30%, 100%);
        align-items: center;

        h2 {
            font: {
                size: 48px;
            }
        }

        div {
            height: 100%;
            width: 300px;

            display: flex;
            flex-direction: column;
            text-align: center;
            justify-content: center;

            img {
                border-radius: 21px;
            }

            a {
                color: $primaryColor;
                text-decoration: none;

                margin-top: 15px;

                font: {
                    family: $secondFont;
                    size: 18px;
                    weight: bold;
                }

                border-radius: 50px;
                border: 3px solid $primaryColor;
                width: 98%;

            }
        }


    }

    .secundary {
        @include content(30%, 100%);
        margin-left: 0;
        margin-top: 0;


        .date {
            @include content(100%, 50%);
        }

        .information {
            @include content(100%, 50%);

        }

    }


    .description {

        align-items: flex-start;

        h3 {
            margin: {
                left: 120px;
            }
        }

        div {
            margin: {
                left: 120px;
                right: 120px;
            }

            p {
                font: {
                    size: 20px;
                }
            }
        }
    }

    .cast {
        align-items: flex-start;

        h3 {
            margin: {
                left: 120px;
            }
        }

        div {

            margin: {
                left: 120px;
                right: 120px;
            }

            ul {

                padding: 0;

            }
        }

    }
}
</style>