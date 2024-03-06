import { defineStore } from 'pinia';
import { ref, computed } from 'vue';
import axios from 'axios';


interface Obra {
    obraId: number;
    titulo: string;
    diaObra: string;
    imagen: string;
    genero: string;
}


export const useFunctionStore = defineStore('FunctionStore', () => {
  // State
  const functions = ref<Array<Obra>>([]);

  // Getter
  const calcularCantidad = computed(() => functions.value.length);

  // Action
  async function fetchFunctions() {
    try {
      const response = await fetch('http://localhost:5000/Obra');
      console.log("Fetch de grid de funciones hecho");
      
      const data = await response.json();
      functions.value = data; // Actualiza la lista de posteos con los datos de la API
    } catch (error) {
      console.error('Error al obtener los posteos:', error);
    }
  }

  return { functions, calcularCantidad, fetchFunctions };
});

