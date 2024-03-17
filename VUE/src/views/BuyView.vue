<script setup lang="ts">
import BuyInputs from '@/components/BuyInputs.vue';
import IconPaypal from '@/components/icons/IconPaypal.vue';
import IconVisa from '@/components/icons/IconVisa.vue';
import router from '@/router';
import { useFunctionStore } from '@/stores/FunctionStore';
import { useSeatStore } from '@/stores/SeatStore';
import { reactive, ref } from 'vue';

const SeatStore = useSeatStore();
const FunctionStore = useFunctionStore();

const dataFunction = FunctionStore.selectedFunction;

// llama al endpoint para reservar las butacas
function payFunction() {
    const idFunction = dataFunction?.obraId as number;

    butacasSeleccionadas.forEach((element: number) => {
        console.log(element);

        SeatStore.selectSeats(idFunction, element, editedSeat);
    });


}

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

// para comprobar en consola las butacas seleccionadas
if (butacasSeleccionadas) {
    // El array está en el localStorage, puedes usarlo como necesites
    console.log("Las butacas seleccionadas en la pagina de compra " + butacasSeleccionadas);
} else {
    // No hay ningún array almacenado en el localStorage
    console.log('No hay butacas seleccionadas en el localStorage');
}

const isValidate = ref<boolean>(false);

// Maneja el evento de validación enviado por los componentes hijos
const handleValidation = (isValid: boolean) => {
    isValidate.value = isValid;
    console.log('en el padre', isValid);
};


const opcionSeleccionada = ref('opcion1'); // Valor por defecto


</script>

<template>
    <div class="content">
        <div class="info">
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
                    <h3 v-for="(seat, index) in butacasSeleccionadas" :key="index">Butaca Nº{{ seat }} | {{
                    dataFunction?.precio }}€</h3>
                </div>
            </div>
            <div>
                <h2>IMPORTE TOTAL</h2>
                <div>
                    <h3>{{ precioTotal }}€</h3>
                </div>
            </div>
        </div>
        <div class="pago">
            <div style="display: flex; align-items: center;">
                <input type="radio" id="opcion1" name="opciones" value="opcion1" checked v-model="opcionSeleccionada">
                <label for="opcion1">
                    <IconPaypal />
                </label>
            </div>

            <div style="display: flex; align-items: center;">
                <input type="radio" id="opcion2" name="opciones" value="opcion2" v-model="opcionSeleccionada">
                <label for="opcion2">
                    <IconVisa />
                </label>



            </div>
            <div id="menuOpcion1" class="menu" v-if="opcionSeleccionada === 'opcion1'">

                <BuyInputs titleInput="CORREO ELECTRONICO" classInput="email" typeInput="email"
                    placeholderInput="example@gmail.com" @validate="handleValidation" />

                <BuyInputs titleInput="CONTRASEÑA" classInput="password" typeInput="password"
                    placeholderInput="Contraseña123" @validate="handleValidation" />




            </div>

            <div id="menuOpcion2" class="menu" v-else>

                <BuyInputs titleInput="TITULAR DE LA TARJETA" classInput="text" typeInput="text"
                    placeholderInput="NOMBRE APELLIDO APELLIDO" @validate="handleValidation" />
                <BuyInputs titleInput="NUMERO DE TARJETA" classInput="text" typeInput="text"
                    placeholderInput="XXXXXXXXXXXXXXXX" @validate="handleValidation" />
                <BuyInputs titleInput="FECHA DE CADUCIDAD" classInput="text" typeInput="text" placeholderInput="MM/AAAA"
                    @validate="handleValidation" />
                <BuyInputs titleInput="CVV" classInput="password" typeInput="password" placeholderInput="123"
                    @validate="handleValidation" />

            </div>

        </div>

        <div class="buttons">
            <RouterLink :to="'/Obra'" @click="SeatStore.deleteSeats">CANCELAR</RouterLink>
            <RouterLink :to="'/Resumen'" @click="payFunction">PAGAR</RouterLink>
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