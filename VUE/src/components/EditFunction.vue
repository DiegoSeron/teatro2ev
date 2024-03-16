<script setup lang="ts">
import { defineProps } from 'vue';
import { reactive, ref } from 'vue';
import { useFunctionStore } from '@/stores/FunctionStore';

const props = defineProps<{
    obraId: number
    titulo: string
    diaObra: Date
    precio: number
    descripcion: string
}>();

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

// Variables para almacenar mensajes de error
const tituloError = ref('');
const descripcionError = ref('');
const diaObraError = ref('');
const precioError = ref('');

// Función para validar el título
const validateTitulo = () => {
    // Validación: Título no puede estar vacío
    if (!editedObra.titulo.trim()) {
        tituloError.value = 'El título es obligatorio';
    } else {
        tituloError.value = '';
    }
};

// Función para validar la descripción
const validateDescripcion = () => {
    // Validación: Descripción no puede estar vacía
    if (!editedObra.descripcion.trim()) {
        descripcionError.value = 'La descripción es obligatoria';
    } else {
        descripcionError.value = '';
    }
};

// Función para validar el día de la obra
const validateDiaObra = () => {
    // Validación: Día de la obra no puede estar vacío
    if (!editedObra.diaObra) {
        diaObraError.value = 'El día de la obra es obligatorio';
    } else {
        diaObraError.value = '';
    }
};

// Función para validar el precio
const validatePrecio = () => {
    // Validación: Precio debe ser un número positivo
    if (editedObra.precio < 0 || isNaN(editedObra.precio)) {
        precioError.value = 'El precio debe ser un número positivo';
    } else {
        precioError.value = '';
    }
};

const submitForm = () => {
    // Validar todos los campos antes de enviar el formulario
    validateTitulo();
    validateDescripcion();
    validateDiaObra();
    validatePrecio();

    // Verificar si hay errores antes de enviar el formulario
    if (tituloError.value || descripcionError.value || diaObraError.value || precioError.value) {
        // Si hay errores, no enviar el formulario
        console.log('Formulario no enviado debido a errores de validación');
        return;
    }

    // Si no hay errores, enviar el formulario
    console.log('Datos editados:', editedObra);
    FunctionStore.editFunction(props.obraId, editedObra);
};
</script>

<template>
    <form @submit.prevent="submitForm" class="edit-form">
        <input type="hidden" name="obraId" v-model="editedObra.obraId" />
        <div class="form-group">
            <label for="title">Título: </label>
            <input type="text" id="title" v-model="editedObra.titulo" class="form-control" />
            <span class="error-message">{{ tituloError }}</span>
        </div>
        <div class="form-group">
            <label for="diaObra">Día de la obra: </label>
            <input type="datetime-local" id="diaObra" v-model="editedObra.diaObra" class="form-control" />
            <span class="error-message">{{ diaObraError }}</span>
        </div>
        <div class="form-group">
            <label for="description">Descripción:</label>
            <textarea id="description" v-model="editedObra.descripcion" class="form-control"></textarea>
            <span class="error-message">{{ descripcionError }}</span>
        </div>
        <div class="form-group">
            <label for="price">Precio:</label>
            <input type="number" id="price" v-model.number="editedObra.precio" class="form-control" />
            <span class="error-message">{{ precioError }}</span>
        </div>
        <button type="submit" class="btn btn-primary">Guardar cambios</button>
    </form>
</template>

<style>
/* Estilos para el mensaje de error */
.error-message {
    color: red;
    font-size: 14px;
}
</style>


<style scoped lang="scss">
@import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@400;700&display=swap');

$secondlyFont: 'Montserrat';

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

        span {
            color: red;
            font-family: $secondlyFont;
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
