<script setup lang="ts">

import { useFunctionStore } from '@/stores/FunctionStore';
import CardGrid from '../components/CardGrid.vue';

const FunctionStore = useFunctionStore();

FunctionStore.fetchFunctions();





</script>

<template>
    <div class="content">
        <section class="functions">


            <CardGrid v-for="obra in FunctionStore.functions" :obraId="obra.obraId" :title="obra.titulo"
                :dia-obra="obra.diaObra.toString()" :imageSrc="obra.imagen" :genero="obra.genero" class="card" />
        </section>


        <aside class="sidebar" id="sidebar">

            <div class="filter">
                <div class="filter__search">
                    <input type="text" placeholder="BUSCAR...">
                </div>
                <div class="filter__gender">
                    <ul>
                        <li><input type="checkbox" class="genre" value="drama">DRAMA</li>
                        <li><input type="checkbox" class="genre" value="romance">ROMANCE</li>
                        <li><input type="checkbox" class="genre" value="comedia">COMEDIA</li>
                        <li><input type="checkbox" class="genre" value="musical">MUSICAL</li>
                        <li><input type="checkbox" class="genre" value="monologo">MONÓLOGO</li>
                        <li><input type="checkbox" class="genre" value="thriller">THRILLER</li>
                    </ul>
                </div>
                <div class="close" id="close" onclick="cerrarFiltros()">
                    cerrar
                </div>
            </div>
        </aside>
    </div>
</template>

<style scoped lang="scss">
@import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@400;700&display=swap');
@import url('https://fonts.googleapis.com/css2?family=Bebas+Neue&display=swap');

$primaryColor: #ba1313;
$primaryFont: 'Bebas Neue';
$secondlyFont: 'Montserrat';


.content {
    width: 100%;
    height: auto;
    display: flex;
    flex-direction: column;
}


.functions {


    width: 100%;
    height: auto;

    display: flex;
    flex-flow: row wrap;
    justify-content: space-evenly;

    .card {
        background-color: $primaryColor;
        width: auto;
        height: auto;
        margin: 10px;
        flex-basis: calc(50% - 20px);
        border-radius: 15px 15px 5px 5px;
        transition: all 300ms ease;
        cursor: pointer;
    }

    .card:hover {
        transform: scale(1.05);

    }

}

.sidebar {
    display: none;
    position: fixed;
    right: 0;
    width: 28%;
    height: auto;

    background-color: #fff;

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

    .functions {
        width: 70%;
        margin: 15px;

        .card {
            flex-basis: calc(31% - 40px);
            margin-bottom: 50px;
        }

    }

    .sidebar {
        display: block !important;

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


}
</style>