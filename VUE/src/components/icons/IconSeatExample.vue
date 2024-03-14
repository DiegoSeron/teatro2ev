<script setup lang="ts">
import { onBeforeUnmount, onMounted, ref } from 'vue'

const props = defineProps<{
    class: string;
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
</script>

<template>
    <div>
        <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 43 35" :width="svgWidth" :height="svgHeight">
            <g ref="seatRef" :class="([props.class])">
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
        <div>
            <p style="padding-left: 10px;">{{ props.class }}</p>
        </div>
    </div>
</template>

<style scoped lang="scss">
@import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@400;700&display=swap');

@mixin cursor {
    cursor: default;
    user-select: none;
}

div {
    flex: 1;
    display: flex;
    justify-content: flex-start;
    align-items: center;
    min-width: 170px;

    font: {
        family: Montserrat;
    }

}


.SELECCIONADAS {
    fill: #ba1313;
    stroke-width: 1;
    stroke: rgb(0, 0, 0);
    @include cursor;
}

.LIBRES {
    fill: white;
    stroke-width: 1;
    stroke: rgb(0, 0, 0);
    @include cursor;
}

.OCUPADAS {
    fill: rgb(50, 50, 50);
    stroke-width: 1;
    stroke: rgb(0, 0, 0);
    @include cursor;
}
</style>
