<script setup lang="ts">
import IconWhiteSeatVue from '@/components/icons/IconSeat.vue';



</script>


<template>
    <div>
        Butacas view
    </div>

    <div class="content">
        <div class="info">
            <div class="info__text">
                <div class="title">
                    <h2>TITULO DE LA FUNCIÓN:</h2>
                    <h3>TITULO DE LA FUNCIÓN:</h3>
                </div>
                <div class="hour">
                    <h2>HORA DE LA FUNCIÓN:</h2>
                    <h3>HORA DE LA FUNCIÓN:</h3>
                </div>
            </div>
            <div class="info__img">
                <img src="../../IMAGENES/jose-el-sonador.jpg" alt="">
            </div>
        </div>
        <div class="selection">
            <div class="title">
                <h2>SELECCION BUTACAS</h2>
            </div>
            <div class="gridButacas">
                <div class="butacas">

                    <div class="fila">
                        <IconWhiteSeatVue colorr="red"/>
                        <IconWhiteSeatVue colorr="white"/>
                        <IconWhiteSeatVue colorr="black"/>

                    </div>
                    

                </div>
                <div class="escenario">
                    <div>escenario</div>
                </div>
            </div>
            <div class="button" id="botonPago">
                <a href="compra.html">IR A PAGAR</a>
            </div>
        </div>
    </div>
</template>