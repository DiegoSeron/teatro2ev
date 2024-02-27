import { defineStore } from "pinia";
import { ref, onMounted } from "vue";
import axios from 'axios';


export const useFunctionsStore = defineStore('functions', () => {
    interface Obra {
        obraId: number;
        titulo: string;
        diaObra: string;
        imagen: string;
        genero: string;
      }

      const datosApi = ref<Array<Obra>>([]);

      
   getters: {
    onMounted(async () => {
        try {
          const response = await axios.get('http://localhost:5000/Obra');
          console.log("Fetch para sacar grid de funciones hecho");
          datosApi.value = response.data;
        } catch (error) {
          console.error('Error al hacer la petición:', error);
        }
      });
  }
  return { datosApi }
})


  
