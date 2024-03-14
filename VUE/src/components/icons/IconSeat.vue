<script setup lang="ts">
import { onBeforeUnmount, onMounted, ref } from 'vue'

const emits = defineEmits(['selectSeat', 'unselectSeat'])

defineProps<{
    isFree: boolean;
    butacaId: number;
}>()

// inicializo el ancho y la altura del SVG
const svgWidth = ref(window.innerWidth > 768 ? 43 : 35);
const svgHeight = ref(window.innerWidth > 768 ? 38 : 27);

// Función para actualizar las dimensiones del SVG en función del ancho de la ventana
const updateSvgDimensions = () => {
    svgWidth.value = window.innerWidth > 768 ? 43 : 35;
    svgHeight.value = window.innerWidth > 768 ? 38 : 27;
};

// Cuando se monta el componente
onMounted(() => {
    window.addEventListener('resize', updateSvgDimensions);
});

// Antes de desmontar el componente
onBeforeUnmount(() => {
    window.removeEventListener('resize', updateSvgDimensions);
});

const seatRef = ref<SVGGElement>();

// Funcion para seleccionar butacas
function chooseSeat(butacaId: number, isFree: boolean) {
    if (seatRef.value) {
        const esLibre = seatRef.value.classList.contains('free');
        // Si la butaca está libre en la base de datos
        if (isFree) {
            console.log("butaca LIBRE en la BBDD");
            // Se agrega la clase de agitación para las butacas libres
            seatRef.value.classList.add('freeShaking');
            // Si se selecciona
            if (seatRef.value.classList.contains('free')) {
                seatRef.value.classList.remove('free');
                seatRef.value.classList.add('choosen');
                seatRef.value.classList.remove('freeShaking');
                seatRef.value.classList.add('choosenShaking');
                emits('selectSeat', butacaId);
            // Si se deselecciona
            } else {
                seatRef.value.classList.remove('choosen');
                seatRef.value.classList.add('free');
                seatRef.value.classList.remove('choosenShaking');
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
    <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 43 35" :width="svgWidth" :height="svgHeight">
        <g ref="seatRef" :class="[isFree ? 'free' : 'taken']" @click="chooseSeat(butacaId, isFree)">
            <!-- respaldo -->
            <rect x="6" y="1" width="30" height="20" rx="5" />

            <!-- asiento -->
            <rect x="6" y="21" width="30" height="10" rx="5" />

            <!-- reposabrazos izquierdo -->
            <rect x="1" y="13" width="10" height="20" rx="5" />

            <!-- reposabrazos derecho -->
            <rect x="31" y="13" width="10" height="20" rx="5" />
            <text x="50%" y="35%" dominant-baseline="middle" text-anchor="middle" fill="black" font-size="16"
                font-family="Montserrat, sans-serif">{{ butacaId }}</text>
        </g>
    </svg>
</template>

<style scoped lang="scss">
@import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@400;700&display=swap');

@mixin cursor($cursor) {
    cursor: $cursor;
    user-select: none;
}

.choosen {
    fill: #ba1313;
    stroke-width: 1;
    stroke: rgb(0, 0, 0);
    @include cursor(pointer);
}

.free {
    fill: white;
    stroke-width: 1;
    stroke: rgb(0, 0, 0);
    @include cursor(pointer);
}

.taken {
    fill: rgb(50, 50, 50);
    stroke-width: 1;
    stroke: rgb(0, 0, 0);
    @include cursor(default);
}

.choosenShaking {
    animation: choosenShake 0.2s;
}
.freeShaking {
    animation: freeShake 0.2s;
}

@keyframes choosenShake {
    0% { transform: translate(0, 0); }
    25% { transform: translate(-4px, 0); }
    50% { transform: translate(4px, 0); }
    75% { transform: translate(-4px, 0); }
    100% { transform: translate(0, 0); }
}

@keyframes freeShake {

    0% { transform: translate(0, 0); }
    25% { transform: translate(-1.5px, 0); }
    50% { transform: translate(1.5px, 0); }
    75% { transform: translate(-1.5px, 0); }
    100% { transform: translate(0, 0); }
}
</style>
