import { defineStore } from 'pinia';
import { ref, computed } from 'vue';
import axios from 'axios';




interface Obra {
  obraId: number;
  titulo: string;
  diaObra: Date;
  imagen: string;
  genero: string;
  duracion: number;
  precio: number;
}

export const useFunctionStore = defineStore('FunctionStore', () => {
  // State
  const functions = ref<Array<Obra>>([]);

  // Getter
    // calcula la cantidad de funciones que hay
  const calcularCantidad = computed(() => functions.value.length);

  // Action
    // saca de la api todas las funciones que hay
  async function fetchFunctions() {
    try {
      const response = await fetch('http://localhost:5000/Obra');
      console.log("Fetch de grid de funciones hecho desde FunctionStore.ts");
      
      const data = await response.json();
      functions.value = data; // Actualiza la lista de posteos con los datos de la api
    } catch (error) {
      console.error('Error al obtener los posteos:', error);
    }
  }

    // busca en la api la funcion por id
  async function fetchFunctionsPerId(id: any) {
    try {
      const response = await fetch('http://localhost:5000/Obra/'+id);
      console.log("Fetch de grid de funciones por id hecho desde FunctionStore.ts");
      
      const data = await response.json();
      functions.value = data; // Actualiza la lista de posteos con los datos de la api
    } catch (error) {
      console.error('Error al obtener los posteos:', error);
    }
  }

  return { functions, calcularCantidad, fetchFunctions, fetchFunctionsPerId };
});

