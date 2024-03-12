<script setup lang="ts">
const props = defineProps<{
    obraId: number
    titulo: string
    diaObra: Date
    precio: number
    descripcion: string
}>();

import { reactive, ref } from 'vue';
import { useFunctionStore } from '@/stores/FunctionStore';

const FunctionStore = useFunctionStore();


interface Obra {
    obraId: number;
    titulo: string;
    diaObra: Date;
    descripcion: string;
    precio: number;
}

const editedObra = reactive<Obra>({
    obraId: props.obraId,
    titulo: props.titulo,
    diaObra: props.diaObra,
    descripcion: props.descripcion,
    precio: props.precio
});

const submitForm = () => {
    console.log('Datos editados:', editedObra);
    FunctionStore.editFunction(props.obraId, editedObra);
};
</script>
  
<template>
    <form @submit.prevent="submitForm" class="edit-form">
        <input type="hidden" name="obraId" v-model="editedObra.obraId" />
      <div class="form-group">
        <label for="title">Título: </label>
        <input type="text" id="title" v-model="editedObra.titulo" class="form-control"/>
      </div>
      <div class="form-group">
        <label for="diaObra">Día de la obra: </label>
        <input type="text" id="diaObra" v-model="editedObra.diaObra" class="form-control"/>
      </div>
      <div class="form-group">
        <label for="description">Descripción:</label>
        <textarea id="description" v-model="editedObra.descripcion" class="form-control"></textarea>
      </div>
      <div class="form-group">
        <label for="price">Precio:</label>
        <input type="number" id="price" v-model.number="editedObra.precio" class="form-control"/>
      </div>
      <button type="submit" class="btn btn-primary">Guardar cambios</button>
    </form>
  </template>

<style scoped lang="scss">
.edit-form {
    max-width: 400px;
    margin: 0 auto;

    .form-group {
        margin-bottom: 20px;

        label {
            display: block;
            margin-bottom: 5px;
        }

        .form-control {
            width: 100%;
            padding: 8px;
            font-size: 16px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }
    }

    .btn {
        padding: 10px 20px;
        font-size: 16px;
        border: none;
        border-radius: 4px;
        cursor: pointer;

        &:focus {
            outline: none;
            box-shadow: 0 0 5px rgba(0, 123, 255, 0.7); // Estilo de enfoque
        }
    }

    .btn-primary {
        background-color: #007bff;
        color: #fff;

        &:hover {
            background-color: #0056b3;
        }
    }
}
</style>
