import {defineStore} from 'pinia';
import {ref, computed} from 'vue';

export const useFunctionStore = defineStore('FunctionStore', ()=>{
    //state - todas las variables son ref
    async () => {
        try {
            const functions = ref(await axios.get('http://localhost:5000/Obra'));
            console.log("Fetch para sacar grid de funciones hecho");
            datosApi.value = functions.data;
        } catch (error) {
            console.error('Error al hacer la petición:', error);
        }
    };
    //getters - para acceder a valores y aplicar calculos usamos computadas
    const calcularCantidad = computed(()=> posts.value.length);
    //actions - son funciones
    function agregarPost(nuevoPost){
        posts.value.push(nuevoPost);
    }

    return{functions, calcularCantidad, agregarPost}
})