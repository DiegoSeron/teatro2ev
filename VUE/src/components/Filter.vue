<script setup lang="ts">
import { computed, ref } from 'vue';
import { useFunctionStore } from '@/stores/FunctionStore';

const FunctionStore = useFunctionStore();

const emits = defineEmits(['filter']);

// Variable reactiva para almacenar el término de búsqueda
const searchTerm = ref('');


function filterByTitle() {
    // Filtrar las funciones según el término de búsqueda
    emits('filter', FunctionStore.filterFunctionsByTitle(searchTerm.value.trim()));

}

function filterByGenre() {
    // Obtener todas las casillas de verificación de género
    const checkboxes = document.querySelectorAll<HTMLInputElement>('.genre');

    // Filtrar las casillas de verificación seleccionadas y obtener los valores de los géneros
    const selectedGenres = Array.from(checkboxes)
        .filter(checkbox => checkbox.checked)
        .map(checkbox => checkbox.value);
    // Filtrar las funciones según los géneros seleccionados
    const filteredFunctions = selectedGenres.length > 0 ? FunctionStore.filterFunctionsByGenre(selectedGenres) : FunctionStore.functions;

    // Emitir el evento con las funciones filtradas
    emits('filter', filteredFunctions);
}

</script>

<template>

    <div class="filter">
        <div class="filter__search">
            <input type="text" v-model="searchTerm" placeholder="Buscar por título (minimo 2 caracteres)"
                @input="filterByTitle()" />
        </div>
        <div class="filter__gender">
            <ul>
                <li><input type="checkbox" class="genre" value="drama" @change="filterByGenre">DRAMA</li>
                <li><input type="checkbox" class="genre" value="romance" @change="filterByGenre">ROMANCE</li>
                <li><input type="checkbox" class="genre" value="comedia" @change="filterByGenre">COMEDIA</li>
                <li><input type="checkbox" class="genre" value="musical" @change="filterByGenre">MUSICAL</li>
                <li><input type="checkbox" class="genre" value="monologo" @change="filterByGenre">MONÓLOGO</li>
                <li><input type="checkbox" class="genre" value="thriller" @change="filterByGenre">THRILLER</li>
                <!-- checkbox sin valor para que funcione el filtro de genero -->
                <li><input type="checkbox" class="genre" value="" @change="filterByGenre" style="display: none;" checked></li>
            </ul>
        </div>
        <div class="close" id="close" onclick="cerrarFiltros()">
            cerrar
        </div>
    </div>
</template>

<style lang="scss">
@import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@400;700&display=swap');
@import url('https://fonts.googleapis.com/css2?family=Bebas+Neue&display=swap');

$primaryColor: #ba1313;
$primaryFont: 'Bebas Neue';
$secondlyFont: 'Montserrat';

.filter {
    width: 100%;
    height: auto;
    position: relative;

    margin: {
        top: 10%;
    }

    &__search {
        width: 100%;
        height: auto;
        display: flex;
        align-items: center;
        justify-content: center;


        input {

            width: 90%;
            border-radius: 50px;
            height: 30px;
        }

        img {
            position: absolute;
            left: 75%;
            width: 20px;
            cursor: pointer;
        }
    }

    &__gender {
        width: 100%;
        height: auto;

        display: flex;
        justify-content: center;

        ul {

            width: 100%;

            padding: 0;

            list-style: none;
            text-align: left;

            display: flex;
            flex-direction: column;
            justify-content: center;
            align-items: flex-start;

            margin: {
                right: 50%;
                left: 50%;
            }


            font: {
                size: 13px;
                family: $secondlyFont;
            }

            li {

                display: flex;
                justify-content: center;
                align-items: center;

                padding: 2%;

                input {
                    appearance: none;
                    -webkit-appearance: none;
                    -moz-appearance: none;

                    width: 20px;
                    height: 20px;

                    border: 1px solid $primaryColor;
                    background-color: #fff;

                }

                input:checked {
                    background-color: $primaryColor;
                }


            }
        }

    }

}

.close {
    padding: 12px;
    background-color: #ba1313;
    border: 2px solid black;
    color: white;
    font-family: $secondlyFont;
}

.iconFilter {
    display: block;
    height: auto;
    width: auto;
    background-color: #ba1313;

    border-radius: 50px;
    padding: 9px;
    color: #fff;
    font-family: $secondlyFont;

    margin: {
        left: 70%;
        top: 15px;
        right: 15px;
        bottom: 15px;
    }

    cursor: pointer;
}

/* PARA ORDENADORES */
@media screen and (min-width: 767px) {

    .filter {
        &__search {
            img {
                left: 82%;
                width: 25px;
            }
        }

        &__gender {
            ul {
                font-size: 18px;
            }
        }
    }
}

.iconFilter {
    display: none;

}

.close {
    display: none;


}
</style>