<script setup lang="ts">
import { reactive, ref } from 'vue';
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
    reparto: string;
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
    precio: 0,
    reparto: ''
});


// Variables para almacenar mensajes de error
const tituloError = ref('');
const descripcionError = ref('');
const diaObraError = ref('');
const repartoError = ref('');
const generoError = ref('');
const duracionError = ref('');
const precioError = ref('');

// Función para validar el título
const validateTitulo = () => {
    // Validación: Título no puede estar vacío
    if (!obra.titulo.trim()) {
        tituloError.value = 'El título es obligatorio';
    } else {
        tituloError.value = '';
    }
};

// Función para validar la descripción
const validateDescripcion = () => {
    // Validación: Descripción no puede estar vacía
    if (!obra.descripcion.trim()) {
        descripcionError.value = 'La descripción es obligatoria';
    } else {
        descripcionError.value = '';
    }
};

// Función para validar el día de la obra
const validateDiaObra = () => {
    // Validación: Día de la obra no puede estar vacío
    if (!obra.diaObra) {
        diaObraError.value = 'El día de la obra es obligatorio';
    } else {
        diaObraError.value = '';
    }
};



// Función para validar el reparto
const validateReparto = () => {
    // Validación: Reparto no puede estar vacío
    if (!obra.reparto.trim()) {
        repartoError.value = 'El reparto es obligatorio';
    } else {
        repartoError.value = '';
    }
};

// Función para validar el género
const validateGenero = () => {
    // Validación: Género no puede estar vacío
    if (!obra.genero.trim()) {
        generoError.value = 'El género es obligatorio';
    } else {
        generoError.value = '';
    }
};

// Función para validar la duración
const validateDuracion = () => {
    // Validación: Duración debe ser un número positivo
    if (obra.duracion <= 0 || isNaN(obra.duracion)) {
        duracionError.value = 'La duración debe ser un número positivo';
    } else {
        duracionError.value = '';
    }
};

// Función para validar el precio
const validatePrecio = () => {
    // Validación: Precio debe ser un número positivo
    if (obra.precio < 0 || isNaN(obra.precio)) {
        precioError.value = 'El precio debe ser un número positivo';
    } else {
        precioError.value = '';
    }
};


const submitForm = async () => {

    try {
        validateTitulo();
        validateDescripcion();
        validateDiaObra();
        validateReparto();
        validateGenero();
        validateDuracion();
        validatePrecio();
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
            <input type="text" id="titulo" v-model="obra.titulo" class="form-control" @input="validateTitulo">
            <span class="error-message">{{ tituloError }}</span>
        </div>

        <div class="form-group">
            <label for="descripcion">Descripción:</label>
            <textarea id="descripcion" v-model="obra.descripcion" class="form-control"
                @input="validateDescripcion"></textarea>
            <span class="error-message">{{ descripcionError }}</span>
        </div>

        <div class="form-group">
            <label for="diaObra">Día de la obra:</label>
            <input type="datetime-local" id="diaObra" v-model="obra.diaObra" class="form-control"
                @input="validateDiaObra">
            <span class="error-message">{{ diaObraError }}</span>
        </div>

        <div class="form-group">
            <label for="imagen">Imagen:</label>
            <input type="text" id="imagen" v-model="obra.imagen" class="form-control">
        </div>

        <div class="form-group">
            <label for="imagen">Reparto:</label>
            <input type="text" id="reparto" v-model="obra.reparto" class="form-control" @input="validateReparto">
            <span class="error-message">{{ repartoError }}</span>
        </div>

        <div class="form-group">
            <label for="genero">Género:</label>
            <select id="genero" v-model="obra.genero" class="form-control" @change="validateGenero">
                <option value="">Selecciona un género</option>
                <option value="Drama">Drama</option>
                <option value="Romance">Romance</option>
                <option value="Comedia">Comedia</option>
                <option value="Musical">Musical</option>
                <option value="Monologo">Monólogo</option>
                <option value="Thriller">Thriller</option>
                <!-- Agrega más opciones según tus necesidades -->
            </select> <span class="error-message">{{ generoError }}</span>
        </div>

        <div class="form-group">
            <label for="duracion">Duración:</label>
            <input type="number" id="duracion" v-model.number="obra.duracion" class="form-control"
                @input="validateDuracion">
            <span class="error-message">{{ duracionError }}</span>
        </div>

        <div class="form-group">
            <label for="precio">Precio:</label>
            <input type="number" id="precio" v-model.number="obra.precio" class="form-control" @input="validatePrecio">
            <span class="error-message">{{ precioError }}</span>
        </div>

        <button type="submit" class="btn btn-primary">Crear Obra</button>
    </form>
</template>


<style scoped lang="scss">
@import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@400;700&display=swap');

$secondlyFont: 'Montserrat';

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