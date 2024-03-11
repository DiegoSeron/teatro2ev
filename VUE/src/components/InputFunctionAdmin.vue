<script setup lang="ts">
import { useFunctionStore } from '@/stores/FunctionStore';
import DeleteFunction from './DeleteFunction.vue';
import EditFunction from './EditFunction.vue';
import { ref } from 'vue';

const FunctionStore = useFunctionStore();
FunctionStore.fetchFunctions();
const editar = ref(false); 
const borrar = ref(false); 

// Función para cambiar el estado de edición
const openEdit = () => {
  editar.value = !editar.value;
}

// Función para cambiar el estado de borrar
const openDelete = () => {
    borrar.value = !borrar.value;
}
</script>

<template>
    <div class="container">
        <button @click="openEdit">{{ editar ? 'Cancelar' : 'Editar' }}</button>
        <button @click="openDelete">{{ borrar ? 'Cancelar' : 'Borrar' }}</button>
        <div v-for="obra in FunctionStore.functions" :key="obra.obraId" class="function">
            <div class="info">
                <h3>{{ obra.titulo }}</h3>
            </div>

            <div class="actions" v-if="borrar">
                <DeleteFunction :description="obra.descripcion" :dia-obra="obra.diaObra" :price="obra.precio" :title="obra.titulo" :obra-id="obra.obraId"/>
            </div>

            <div class="menu" v-if="editar"> 
                <EditFunction  :description="obra.descripcion" :dia-obra="obra.diaObra" :price="obra.precio" :title="obra.titulo" :obra-id="obra.obraId"/>
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
}

.function {
    margin-bottom: 20px;
    padding: 20px;
    border: 1px solid #ccc;
    border-radius: 8px;
    display: flex;
    justify-content: center;
    align-items: center;
    min-width: 400px;
    max-width: 400px;

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