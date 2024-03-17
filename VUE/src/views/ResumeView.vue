<script setup lang="ts">
import BuyInputs from '@/components/BuyInputs.vue';
import IconPaypal from '@/components/icons/IconPaypal.vue';
import IconVisa from '@/components/icons/IconVisa.vue';
import { useFunctionStore } from '@/stores/FunctionStore';
import { useSeatStore } from '@/stores/SeatStore';
import { reactive, ref } from 'vue';

const SeatStore = useSeatStore();
const FunctionStore = useFunctionStore();

const dataFunction = FunctionStore.selectedFunction;

interface seat {
    libre: boolean
}

const editedSeat = reactive<seat>({
    libre: false,

});

// Recupera las butacas seleccionadas de sessionStorage
const butacasSeleccionadas = SeatStore.choosenSeats
// Función de comparación para ordenar los números de menor a mayor
const compararNumeros = (a: number, b: number) => a - b;
// Ordenar el array de butacas seleccionadas de menor a mayor
butacasSeleccionadas.sort(compararNumeros);

// obtener el precio total de la compra
const precioTotal = dataFunction?.precio as number * butacasSeleccionadas.length;







</script>

<template>
    <div class="content">
        <div class="info">
            <div>
                <h2>COMPRA FINALIZADA</h2>
                <h2>RESUMEN: </h2>
            </div>
            <div>
                <h2>TITULO</h2>
                <h3>{{ dataFunction?.titulo }}</h3>
            </div>
            <div>
                <h2>FECHA</h2>
                <h3>{{ FunctionStore.formatoFecha(dataFunction?.diaObra.toString() as string) }}</h3>
            </div>
            <div>
                <h2>BUTACAS SELECCIONADAS</h2>
                <div>
                    <h3 v-for="(seat, index) in butacasSeleccionadas" :key="index">Butaca Nº{{ seat }}</h3>
                </div>
            </div>
            <div>
                <h2>IMPORTE TOTAL</h2>
                <div>
                    <h3 >{{ precioTotal }}€</h3>
                </div>
            </div>
            <div>
                <h2>GRACIAS POR LA COMPRA Y DISFRUTE DE LA FUNCION</h2>
            </div>
        </div>

        <div class="buttons">
            <RouterLink :to="'/Obra'" @click="SeatStore.deleteSeats" >VOLVER A LA PAGINA PRINCIPAL</RouterLink>
        </div>
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

@mixin h2($fontSize) {
    padding: 0;


    margin: {
        bottom: 0;

    }

    font: {
        family: $primaryFont;
        size: $fontSize;
    }

    color: $primaryColor;
}

@mixin h3($fontSize) {
    margin: {
        top: 0;
        bottom: 5%;
    }

    font: {
        family: $secondFont;
        size: $fontSize;
    }
}

@mixin button() {
    text-decoration: none;
    font-weight: bold;

    border: 2px solid $primaryColor;
    border-radius: 50px;

    padding: 15px;

    margin: 30px;


    font-family: $secondFont;
    color: $primaryColor;

}

body {
    background-color: white;
    text-align: center;
    padding: 0px;
    margin: 0px;
}

.content {
    width: 100%;
    height: auto;

    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;

}

.info {
    width: 80%;
    height: auto;

    border: 1px solid black;
    margin: 20px;

    margin-top: 40px;

    display: flex;
    flex-direction: column;
    align-items: center;

    h2 {
        @include h2(30px);
    }

    h3 {
        @include h3(18px);

    }


}

.pago {
    width: 80%;
    height: auto;

    border: 1px solid black;
    margin: 20px;

    text-align: left;


    div {

        margin: {
            top: 20px;
            left: 5px;
        }

        input[type="radio"] {
            margin-top: 0;
        }

        img {
            width: 20%;
            height: auto;
        }
    }


    .menu {
        height: auto;
        width: auto;
        padding-bottom: 15px;

    }

}

.buttons {
    margin-top: 20px;
    padding-bottom: 50px;

    a {
        @include button();

    }
}


/* PARA ORDENADORES */
@media screen and (min-width: 767px) {
    .info {


    h2 {
        @include h2(36px);
    }

    h3 {
        @include h3(25px);

    }


}

    .pago {
        div {
            label {
                width: 30%;
                height: auto;
            }
        }
    }
}
</style>