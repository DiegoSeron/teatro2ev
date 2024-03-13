<script setup lang="ts">
import BuyInputs from '@/components/BuyInputs.vue';
import { useSeatStore } from '@/stores/SeatStore';
import { reactive, ref } from 'vue';

const SeatStore = useSeatStore();

function payFunction() {
    
    const idFunction = 2;
    const butaca = 1;

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
const butacasSeleccionadas = JSON.parse(sessionStorage.getItem('choosenSeats') as string) || [];
if (butacasSeleccionadas) {
    // El array está en el localStorage, puedes usarlo como necesites
    console.log("Las butacas seleccionadas en la pagina de compra " + butacasSeleccionadas);
} else {
    // No hay ningún array almacenado en el localStorage
    console.log('No hay butacas seleccionadas en el localStorage');
}

const opcionSeleccionada = ref('opcion1'); // Valor por defecto

</script>

<template>
    Compra View

    <div class="content">
        <div class="info">
            <div>
                <h2>RESUMEN DE LA COMPRA</h2>
            </div>

            <div>
                <h2>TITULO DE LA FUNCIÓN</h2>
                <h3>TITULO DE LA FUNCIÓN</h3>
            </div>
            <div>
                <h2>HORA DE LA FUNCIÓN</h2>
                <h3>HORA DE LA FUNCIÓN</h3>
            </div>
            <div>
                <h2>BUTACAS SELECCIONADAS</h2>

                <h3 id="butacasSeleccionadas" style="display: flex; padding: 5px;">
                    Las butacasa seleccionadas son:
                    <p v-for="b in butacasSeleccionadas">{{ b }}</p>

                </h3>
            </div>
        </div>
        <div class="pago">
            <div>
                <input type="radio" id="opcion1" name="opciones" value="opcion1" checked v-model="opcionSeleccionada">
                <label for="opcion1">Opción 1</label>
            </div>

            <div>
                <input type="radio" id="opcion2" name="opciones" value="opcion2" v-model="opcionSeleccionada">
                <label for="opcion2">Opción 2</label>



            </div>
            <div id="menuOpcion1" class="menu" v-show="opcionSeleccionada === 'opcion1'">

                <BuyInputs titleInput="CORREO ELECTRONICO" classInput="email" typeInput="email"
                    placeholderInput="example@gmail.com" />

                <BuyInputs titleInput="CONTRASEÑA" classInput="password" typeInput="password"
                    placeholderInput="Contraseña123" />




            </div>

            <div id="menuOpcion2" class="menu" v-show="opcionSeleccionada === 'opcion2'">

                <BuyInputs titleInput="TITULAR DE LA TARJETA" classInput="text" typeInput="text"
                    placeholderInput="NOMBRE APELLIDO APELLIDO" />
                <BuyInputs titleInput="NUMERO DE TARJETA" classInput="text" typeInput="text"
                    placeholderInput="XXXXXXXXXXXXXXXX" />
                <BuyInputs titleInput="FECHA DE CADUCIDAD" classInput="text" typeInput="text" placeholderInput="MM/AAAA" />
                <BuyInputs titleInput="CVV" classInput="password" typeInput="password" placeholderInput="123" />

            </div>

        </div>

        <div class="buttons">
            <RouterLink :to="'/Obra'">CANCELAR</RouterLink>
            <RouterLink :to="'/Obra'" @click="payFunction">PAGAR</RouterLink>
        </div>
    </div>
</template>

<style scoped lang="scss"> @import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@400;700&display=swap');
 @import url('https://fonts.googleapis.com/css2?family=Bebas+Neue&display=swap');
 @import url('https://fonts.googleapis.com/css?family=Merryweather');


 $primaryColor: #ba1313;
 $primaryFont: 'Bebas Neue';
 $secondFont: 'Montserrat';
 $thirdFont: 'Merryweather';

 @mixin h2() {
     padding: 0;

     margin: {
         bottom: 0;
         left: 6%;
         right: 6%;
     }

     font-family: $primaryFont;
     color: $primaryColor;
 }

 @mixin h3() {
     margin: {
         top: 0;
         bottom: 5%;
     }

     font-family: $secondFont;
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
         @include h2();
     }

     h3 {
         @include h3();
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
     padding-bottom: 30px;

     a {
         @include button();

     }
 }


 /* PARA ORDENADORES */
 @media screen and (min-width: 767px) {


     .pago {
         div {
             img {
                 width: 10%;
                 height: auto;
             }
         }
     }
 }
</style>