<script setup lang="ts">
import IconSeatVue from '@/components/icons/IconSeat.vue';
import { ref, onMounted } from 'vue';
import { useRoute } from 'vue-router';
import { useFunctionStore } from '@/stores/FunctionStore';
import { useSeatStore } from '@/stores/SeatStore';
import IconStage from '@/components/icons/IconStage.vue';
import IconSeatExample from '@/components/icons/IconSeatExample.vue';

// cojo la url y el id de la obra
const route = useRoute();
const id = Number.parseInt(route.params.id as string);

// llamo al FunctionStore y hago el fetch con el id de la obra
const FunctionStore = useFunctionStore();
FunctionStore.searchFunctionsPerId(id);
const Idfunction = FunctionStore.searchFunctionsPerId(id);


// llamo al SeatStore y hago el fetch con el id de la obra
const SeatStore = useSeatStore();
SeatStore.fetchSeatsPerId(id);




</script>


<template>
    <div class="content">
        <div class="info">
            <div class="info__text">
                <div class="title">
                    <h2>TITULO DE LA FUNCIÓN:</h2>
                    <h3>{{ Idfunction?.titulo }}</h3>
                </div>
                <div class="hour">
                    <h2>HORA DE LA FUNCIÓN:</h2>
                    <h3>{{ FunctionStore.formatoHora(Idfunction?.diaObra.toString() as string) }}</h3>
                </div>
            </div>
            <div class="info__img">
                <img :src="'../src/assets/IMAGENES/' + Idfunction?.imagen" alt="">
            </div>
        </div>
        <div class="selection">
            <div class="title">
                <h2>SELECCION BUTACAS</h2>
            </div>

            <div class="selectorButacas">
                <div class="datos">

                    <IconSeatExample class="LIBRES" />
                    <IconSeatExample class="SELECCIONADAS" />
                    <IconSeatExample class="OCUPADAS" />
                </div>
                <div class="d">
                    <div class="escenario">
                        <IconStage />
                    </div>
                    <div class="butacas">
                        <div v-for="filaIndex in 10" :key="filaIndex">
                            <div class="fila">
                                <IconSeatVue class="butaca"
                                    v-for="(butaca, index) in SeatStore.seats.slice((filaIndex - 1) * 10, filaIndex * 10)"
                                    :key="butaca.butacaId" :isFree="butaca.libre" :butacaId="(butaca.butacaId as number)"
                                    @selectSeat="SeatStore.onChooseSeat" @unselectSeat="SeatStore.onUnchooseSeat"
                                    :example="false" />
                            </div>

                        </div>
                    </div>
                </div>


            </div>

            <div class="button" id="botonPago" >
                <RouterLink :to="'/Compra'"  v-if="SeatStore.choosenSeats.length">IR A PAGAR</RouterLink>
                <div v-else>SELECCIONE BUTACA</div>
            </div>
        </div>
    </div>
</template>


<style scoped lang="scss">
.content {
    width: 100%;
    display: flex;
    flex-direction: column;

    .info {
        width: 100%;
        height: auto;
        display: flex;
        flex-direction: row;
        align-items: center;
        justify-content: center;

        &__text {
            width: 50%;
            height: auto;
            background-color: #fff;
            margin-top: 5px;

            div {
                display: flex;
                flex-direction: column;
                align-items: center;
                justify-content: center;

                h2 {
                    margin-top: 5%;
                    margin-bottom: 0;
                    margin-left: 6%;
                    margin-right: 6%;
                    font-family: "Bebas Neue";
                    color: #ffffff;
                    color: #ba1313;
                }

                h3 {
                    margin-top: 0;
                    margin-bottom: 5%;
                    font-family: "Montserrat";
                }
            }
        }

        &__img {
            width: 50%;
            height: 100%;
            background-color: #fff;
            margin-top: 5px;

            img {
                width: 55%;
                height: auto;
                border-radius: 15px;
                margin-top: 5%;
            }
        }
    }

    .selection {
        width: 100%;
        height: auto;
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;

        .title {
            width: 100%;
            height: 15%;
            background-color: #ba1313;
            margin-top: 5%;
            margin-bottom: 0;
            margin-left: 6%;
            margin-right: 6%;
            font-family: "Bebas Neue";
            color: #ffffff;
        }

        .selectorButacas {
            width: 100%;
            height: 70%;

            .datos {
                display: flex;
                flex-direction: column;
                align-items: center;
            }

            .d {
                display: flex;
                flex-direction: column;

                margin: {
                    top: 20px;
                }

                .escenario {
                    padding-bottom: 20px;
                }

                .butacas {
                    height: 380px;
                    display: grid;
                    grid-template-rows: repeat(10, 30px);
                    grid-gap: 5px;
                    justify-content: center;
                    align-items: center;

                    div .fila {
                        padding: 0;
                        display: flex;
                        align-items: center;
                        justify-content: center;
                    }



                }
            }


        }



        .button {
            width: 100%;
            height: 15%;
            margin: 20px;
            display: flex;
            justify-content: center;
            align-items: center;



            a, div {
                color: #ffffff;
                text-decoration: none;
                background-color: #ba1313;
                padding: 10px;
                font-family: "Montserrat";
                font-size: 18px;
                border-radius: 50px;
            }
        }


    }
}

// PARA ORDENADORES
@media screen and (min-width: 900px) {
    .content {
        .info {

            &__text {
                width: 30%;

                h2 {

                    font-size: 50px;
                }

                h3 {
                    font-size: 30px;

                }

            }

            &__img {
                img {
                    width: 40%;

                }
            }
        }

        .selection {
            .selectorButacas {
                display: flex;
                flex-direction: row;
                align-items: center;
                justify-content: center;

                .datos {
                    display: flex;
                    flex-direction: column;
                    align-items: center;
                    justify-content: center;
                    width: 20%;
                }

                .d {
                    display: flex;
                    flex-direction: column;

                    margin: {
                        top: 40px;
                    }

                    .escenario {
                        padding-bottom: 40px;
                    }

                    .butacas {
                        height: auto;
                        grid-gap: 10px;


                        div .fila {
                            .butaca {
                                margin: 5px;
                            }
                        }



                    }
                }


            }

            .button {
                padding: {
                    top: 60px;
                    bottom: 20px;
                }
            }
        }
    }

}
</style>
