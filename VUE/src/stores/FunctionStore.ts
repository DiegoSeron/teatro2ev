import { defineStore } from 'pinia';
import { computed, reactive } from 'vue';




interface Obra {
  obraId: number;
  titulo: string;
  diaObra: Date;
  precio: number;
  descripcion: string;
  imagen?: string;
  genero?: string;
  duracion?: number;
}

export const useFunctionStore = defineStore('FunctionStore', () => {
  // State
  const functions = reactive(new Array<Obra>);


  // Getter
  // calcula la cantidad de funciones que hay
  const calcularCantidad = computed(() => functions.length);

  // Action
  // saca de la api todas las funciones que hay
  async function fetchFunctions() {
    try {
      const response = await fetch('http://localhost:5000/Obra');
      console.log("Fetch de grid de funciones hecho desde FunctionStore.ts");

      const data = await response.json();
      functions.splice(0, functions.length)
      functions.push(...data);
      // Actualiza la lista de posteos con los datos de la api
    } catch (error) {
      console.error('Error al obtener los posteos:', error);
    }
  }

  // busca en la api la funcion por id
  function searchFunctionsPerId(id: number) {
    return functions.filter(i => i.obraId === id)[0];
  }

  // eliminar obra
  async function deleteFunction(id: number) {
    try {
      const response = await fetch('http://localhost:5000/Obra/' + id, {
        method: 'DELETE',
      });
      console.log("Fetch de eliminar funcion " + id + " hecho desde FunctionStore.ts");

    } catch (error) {
      console.error('Error al eliminar:', error);
    }
  }

  // crear obra
  async function createFunction(obra: Obra) {
    try {
      const response = await fetch('http://localhost:5000/Obra', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json', // Indica que estás enviando datos en formato JSON
        },
        body: JSON.stringify(obra), // Convierte el objeto obra a JSON y lo envía en el cuerpo de la solicitud
        
      });
      if (response.ok) {
        console.log('Obra creada exitosamente.');
      } else {
        console.error('Error al crear la obra:', response.statusText);
      }
    } catch (error) {
      console.error('Error al crear la obra:', error);
    }
  }

  // editar obra
  async function editFunction(id: number, obra: Obra) {
    try {
      const response = await fetch('http://localhost:5000/Obra/' + id, {
        method: 'PUT',
        headers: {
          'Content-Type': 'application/json', // Indica que estás enviando datos en formato JSON
        },
        body: JSON.stringify(obra), // Convierte el objeto obra a JSON y lo envía en el cuerpo de la solicitud
        
      });
      if (response.ok) {
        console.log('Obra editada exitosamente.');
      } else {
        console.error('Error al editar la obra:', response.statusText);
      }
    } catch (error) {
      console.error('Error al editar la obra:', error);
    }
  }



  return { functions, calcularCantidad, fetchFunctions, searchFunctionsPerId, deleteFunction, createFunction, editFunction };
});

