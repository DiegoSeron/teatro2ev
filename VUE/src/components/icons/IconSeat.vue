<script setup lang="ts">
import { ref } from 'vue'

const emits = defineEmits(['selectSeat', 'unselectSeat'])

defineProps<{
    isFree: boolean;
    butacaId: number;
}>()

const seatRef = ref<SVGGElement>();

// Funcion para seleccionar butacas
function chooseSeat(butacaId: number, isFree: boolean) {
    if (seatRef.value) {
        const esLibre = seatRef.value.classList.contains('free');
        // Si la butaca está libre en la base de datos
        if (isFree) { 
            console.log("butaca LIBRE en la BBDD");
            // Si se selecciona
            if (esLibre) { 
                seatRef.value.classList.remove('free');
                seatRef.value.classList.add('choosen');
                emits('selectSeat', butacaId);
            // Si se deselecciona
            } else {
                seatRef.value.classList.remove('choosen');
                seatRef.value.classList.add('free');
                emits('unselectSeat', butacaId);
            }

        // Si la butaca está ocupada en la base de datos
        } else {
            console.log("butaca OCUPADA en la BBDD: " + butacaId);
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