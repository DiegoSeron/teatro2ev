<script setup lang="ts">
import { ref } from 'vue'

defineProps<{
    isFree: boolean;
    butacaId: number;
}>()

const seatRef = ref<SVGGElement>();

// Funcion para selccionar butacas
function chooseSeat(butacaId: number, isFree: boolean) {
    if (seatRef.value) {
        const esLibre = seatRef.value.classList.contains('free'); // si la butaca contiene la clase free (libre)
        // Si esta libre en la base de datos
        if (isFree) { 
            console.log("butaca LIBRE: " + butacaId);
            // Si se selecciona
            if (esLibre) { 
                console.log("Butaca Seleccionada");
                seatRef.value.classList.remove('free');
                seatRef.value.classList.add('choosen');
            // Si se deselecciona
            } else {
                console.log("Butaca Deseleccionada");
                seatRef.value.classList.remove('choosen');
                seatRef.value.classList.add('free');
            }
        // Si esta ocupada en la base de datos
        } else {
            console.log("butaca OCUPADA: " + butacaId);
        }
    }
}
</script>

<template>
    <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 43 35" width="43" height="35">
        <g ref="seatRef" :class="[isFree ? 'free' : 'taken']" @click="chooseSeat(butacaId, isFree)">
            <!-- respaldo -->
            <rect x="6" y="1" width="30" height="20" rx="5" />

            <!-- asiento -->
            <rect x="6" y="21" width="30" height="10" rx="5" />

            <!-- reposabrazos izquierdo -->
            <rect x="1" y="13" width="10" height="20" rx="5" />

            <!-- reposabrazos derecho -->
            <rect x="31" y="13" width="10" height="20" rx="5" />
        </g>
    </svg>
</template>

<style>
.choosen {
    fill: #ba1313;
    stroke-width: 1;
    stroke: rgb(0, 0, 0);
}

.free {
    fill: white;
    stroke-width: 1;
    stroke: rgb(0, 0, 0);
}

.taken {
    fill: rgb(50, 50, 50);
    stroke-width: 1;
    stroke: rgb(0, 0, 0);
}
</style>
