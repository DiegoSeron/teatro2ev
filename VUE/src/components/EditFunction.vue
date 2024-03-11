<script setup lang="ts">
defineProps<{
    obraId: number
    title?: string
    diaObra?: string
    precio?: number
}>()

import { ref } from 'vue';



interface Obra {
    obraId: number;
    title?: string;
    diaObra?: string;
    description: string;
    price: number;
}

// Data que se editará
const editedObra = ref<Obra>({
    obraId: 0,
    title: '',
    diaObra: '',
    description: '',
    price: 0
});

// Método para enviar el formulario
const submitForm = () => {
    console.log('Datos editados:', editedObra.value);
};
</script>
  
<template>
    <form @submit.prevent="submitForm" class="edit-form">
        <div class="form-group">
            <label for="title">Título: </label>
            <input type="text" id="title" v-model="editedObra.title" class="form-control" />
        </div>

        <div class="form-group">
            <label for="diaObra">Día de la obra: </label>
            <input type="text" id="diaObra" v-model="editedObra.diaObra" class="form-control" />
        </div>

        <div class="form-group">
            <label for="description">Descripción:</label>
            <textarea id="description" v-model="editedObra.description" class="form-control"></textarea>
        </div>

        <div class="form-group">
            <label for="price">Precio:</label>
            <input type="number" id="price" v-model.number="editedObra.price" class="form-control" />
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