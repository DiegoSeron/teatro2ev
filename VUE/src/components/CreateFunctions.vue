<script setup lang="ts">
import { reactive } from 'vue';
import { useFunctionStore } from '@/stores/FunctionStore';

const FunctionStore = useFunctionStore();

interface Obra {
    obraId: number;
    titulo: string;
    descripcion: string;
    diaObra: Date;
    imagen: string;
    genero: string;
    duracion: number;
    precio: number;
}

// inicializo una obra
const obra = reactive<Obra>({
    obraId: 0,
    titulo: '',
    descripcion: '',
    diaObra: new Date(),
    imagen: '',
    genero: '',
    duracion: 0,
    precio: 0
});

const submitForm = async () => {
    try {
        // Llamada a createFunction con los datos de la obra
        await FunctionStore.createFunction(obra);
        console.log('Datos de la nueva obra enviados al servidor.');
    } catch (error) {
        console.error('Error al enviar los datos de la obra al servidor:', error);
    }
};
</script>

<template>
    <form @submit.prevent="submitForm" class="create-form">
        <div class="form-group">
            <label for="titulo">Título:</label>
            <input type="text" id="titulo" v-model="obra.titulo" class="form-control" />
        </div>

        <div class="form-group">
            <label for="descripcion">Descripción:</label>
            <textarea id="descripcion" v-model="obra.descripcion" class="form-control"></textarea>
        </div>

        <div class="form-group">
            <label for="diaObra">Día de la obra:</label>
            <input type="datetime-local" id="diaObra" v-model="obra.diaObra" class="form-control" />
        </div>

        <div class="form-group">
            <label for="imagen">Imagen:</label>
            <input type="text" id="imagen" v-model="obra.imagen" class="form-control" />
        </div>

        <div class="form-group">
            <label for="genero">Género:</label>
            <input type="text" id="genero" v-model="obra.genero" class="form-control" />
        </div>

        <div class="form-group">
            <label for="duracion">Duración:</label>
            <input type="number" id="duracion" v-model.number="obra.duracion" class="form-control" />
        </div>

        <div class="form-group">
            <label for="precio">Precio:</label>
            <input type="number" id="precio" v-model.number="obra.precio" class="form-control" />
        </div>

        <button type="submit" class="btn btn-primary">Crear Obra</button>
    </form>
</template>



<style scoped lang="scss">
.create-form {
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