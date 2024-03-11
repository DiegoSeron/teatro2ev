<script setup lang="ts">
import { useFunctionStore } from '@/stores/FunctionStore';
import DeleteFunction from './DeleteFunction.vue';
import EditFunction from './EditFunction.vue';
import { ref } from 'vue';

const FunctionStore = useFunctionStore();
FunctionStore.fetchFunctions();
const editar = ref('')
</script>

<template>
    <div class="container">
        <div v-for="obra in FunctionStore.functions" :key="obra.obraId" class="function">
            <div class="info">
                <h3>{{ obra.titulo }}</h3>
            </div>

            
            <div class="actions">
                <input type="button" value="editar" v-model="editar"></input>
                <DeleteFunction />
            </div>
            <div id="menuOpcion1" class="menu" v-show="editar === 'editar'">
                <EditFunction />


            </div>
        </div>
    </div>
    
</template>

<style scoped lang="scss">
.container {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    /* Ajusta la altura según tus necesidades */
}

.function {
    margin-bottom: 20px;
    padding: 20px;
    border: 1px solid #ccc;
    border-radius: 8px;
    display: flex;
    justify-content: center;
    align-items: center;
    max-width: 400px;
    /* Ajusta el ancho máximo según tus necesidades */

    .info {
        flex-grow: 1;
        text-align: left;

        h3 {
            margin-bottom: 10px;
            font-size: 1.5em;
            color: #333;
        }

        p {
            color: #666;
        }
    }

    .actions {
        display: flex;
        align-items: center;

    }
}
</style>