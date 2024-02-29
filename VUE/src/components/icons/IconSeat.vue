<script setup lang="ts">
defineProps<{
    isFree: boolean;
    butacaId: number;
}>()

function chooseSeat(event: MouseEvent, butacaId: number, isFree: boolean) {
    // Aquí puedes realizar acciones cuando se elija la butaca
    console.log('Butaca elegida:', butacaId);
    const target = event.target as SVGElement;
    if (isFree) {
        target.classList.remove('free');
        target.classList.add('choosen');
    } else {
        target.classList.remove('choosen');
        target.classList.add('free');
    }
}


</script>

<template>
    <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 43 35" width="43" height="35" @click="chooseSeat($event, butacaId, isFree)" >
        <!-- respaldo -->
        <rect x="6" y="1" width="30" height="20" rx="5" :class="[isFree ? 'free' : 'taken']" />

        <!-- asiento -->
        <rect x="6" y="21" width="30" height="10" rx="5" :class="[isFree ? 'free' : 'taken']" />

        <!-- reposabrazos izquierdo -->
        <rect x="1" y="13" width="10" height="20" rx="5" :class="[isFree ? 'free' : 'taken']" />

        <!-- reposabrazos derecho -->
        <rect x="31" y="13" width="10" height="20" rx="5" :class="[isFree ? 'free' : 'taken']" />
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
