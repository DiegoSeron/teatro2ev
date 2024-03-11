<script setup lang="ts">
import { useFunctionStore } from '@/stores/FunctionStore';

const FunctionStore = useFunctionStore();

const Idfunction = FunctionStore.searchFunctionsPerId(id);

</script>

<template>
<h2>Eliminar Función</h2>
</template>

<style scoped lang="scss">

</style>