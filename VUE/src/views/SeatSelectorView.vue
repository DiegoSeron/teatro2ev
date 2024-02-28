<script setup lang="ts">
import IconWhiteSeatVue from '@/components/icons/IconSeat.vue';


import { ref, onMounted } from 'vue';
import axios from 'axios';
import { useRoute } from 'vue-router';


interface Obra {
  obraId: number;
  titulo: string;
  diaObra: Date;
  imagen: string;
  genero: string;
  horaObra: Date;
  duracion: number;
  precio: number;
}

const datosApi = ref<Array<Obra>>([]);
const route = useRoute();
const id = route.params.id;
onMounted(async () => {
  try {
    
    const response = await axios.get(`http://localhost:5000/Obra/${id}`);
    console.log("Fetch para sacar descripcion de obra hecho");
    datosApi.value = response.data;
  } catch (error) {
    console.error('Error al hacer la petición:', error);
  }
});


interface Butaca {
    obraId: number;
    butacaId: number;
    libre: boolean;

}

const datosApiButaca = ref<Array<Butaca>>([]);

onMounted(async () => {
    try {
        const response = await axios.get(`http://localhost:5000/Seat/${id}`);
        console.log("Fetch para sacar butacas por obra id");
        datosApiButaca.value = response.data;
        console.log(datosApiButaca.value);
        
    } catch (error) {
        console.error('Error al hacer la petición:', error);
    }
});

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
                    <h3>{{ datosApi.titulo }}</h3>
                </div>
                <div class="hour">
                    <h2>HORA DE LA FUNCIÓN:</h2>
                    <h3>{{ datosApi.diaObra }}</h3>
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
                        <IconWhiteSeatVue v-for="butaca in datosApiButaca" :key="butaca.butacaId" :colorr="butaca.libre ? 'white' : 'black'"/>
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