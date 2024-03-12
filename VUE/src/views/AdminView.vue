<script setup lang="ts">
import { ref } from 'vue';
import InputFunctionAdmin from './../components/InputFunctionAdmin.vue';
import CreateFunctions from '@/components/CreateFunctions.vue';

const opcionSeleccionada = ref('opcion1'); // Valor por defecto

</script>

<template>
Admin View

<div class="pago">
            <div>
                <input type="radio" id="opcion1" name="opciones" value="opcion1" v-model="opcionSeleccionada">
                <label for="opcion1">CREAR</label>
            </div>

            <div>
                <input type="radio" id="opcion2" name="opciones" value="opcion2" v-model="opcionSeleccionada">
                <label for="opcion2">EDITAR / BORRAR</label>


            </div>
            <div id="menuOpcion1" class="menu" v-show="opcionSeleccionada === 'opcion1'">
                <CreateFunctions/>


            </div>

            <div id="menuOpcion2" class="menu" v-show="opcionSeleccionada === 'opcion2'">

                <InputFunctionAdmin/>


            </div>

        </div>

</template>

<style scoped lang="scss">

</style>