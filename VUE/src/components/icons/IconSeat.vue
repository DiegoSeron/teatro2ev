<script setup lang="ts">
defineProps<{
    colorr: string;
  }>()
 
</script>

<template>
    <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 43 35" width="43" height="35">
        <!-- respaldo -->
        <rect x="6" y="1" width="30" height="20" rx="5" :class="[colorr]"/>

        <!-- asiento -->
        <rect x="6" y="21" width="30" height="10" rx="5" :class="[colorr]" />

        <!-- reposabrazos izquierdo -->
        <rect x="1" y="13" width="10" height="20" rx="5" :class="[colorr]" />

        <!-- reposabrazos derecho -->
        <rect x="31" y="13" width="10" height="20" rx="5" :class="[colorr]" />

    </svg>
</template>

<style>
.red{
    fill:#ba1313;
    stroke-width:1;
    stroke:rgb(0,0,0)
}

.white{
    fill:white;
    stroke-width:1;
    stroke:rgb(0,0,0)
}

.black{
    fill:rgb(50,50,50);
    stroke-width:1;
    stroke:rgb(0,0,0)
}
</style>