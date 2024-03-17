import { defineStore } from 'pinia';
import { computed, reactive, ref } from 'vue';

interface Obra {
  obraId: number;
  titulo: string;
  diaObra: Date;
  precio: number;
  descripcion: string;
  imagen?: string;
  reparto?: string;
  genero?: string;
  duracion?: number;
}

export const useFunctionStore = defineStore('FunctionStore', () => {
  // State
  const functions = reactive(new Array<Obra>);
  const selectedFunctionId = ref<number>(-1); // Inicializa con un valor que represente que no hay ninguna obra seleccionada



  // Getter
  // calcula la cantidad de funciones que hay
  const calcularCantidad = computed(() => functions.length);

  // Getter para obtener la obra seleccionada
  const selectedFunction = computed(() => {
    if (selectedFunctionId.value !== null) {
      return functions.find(func => func.obraId === selectedFunctionId.value);
    }
    return null;
  });




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
    selectedFunctionId.value = id; // Almacena el ID de la obra buscada
    return functions.find(i => i.obraId === id);
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


  // funcion para sacar el dia de la obra
  const formatoFecha = (fechaHora: string) => {
    const fecha = new Date(fechaHora)
    const options: Intl.DateTimeFormatOptions = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric', hour: 'numeric', minute: 'numeric' };
    return fecha.toLocaleDateString('es-ES', options);
  };

  // funcion para sacar el dia de la obra
  const formatoDia = (fechaHora: string) => {
    const fecha = new Date(fechaHora)
    const options: Intl.DateTimeFormatOptions = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' };
    return fecha.toLocaleDateString('es-ES', options);
  };

  // funcion para sacar la hora de la obra
  const formatoHora = (fechaHora: string) => {
    const hora = new Date(fechaHora);
    const options: Intl.DateTimeFormatOptions = { hour: 'numeric', minute: 'numeric' };
    return hora.toLocaleTimeString('es-ES', options);
  };

  // Filtrar funciones por título
  function filterFunctionsByTitle(title: string) {
    console.log('Busco por titulo en la store');
    if (title.length < 2){      
      return functions;
    }else {
      const functionsFiltered = functions.filter(func => func.titulo.toLowerCase().includes(title.toLowerCase()));
      return functionsFiltered
    }
  }

  function filterFunctionsByGenre(genres: string[]) {
    console.log('Busco por género en la store');
    console.log(genres);

    // Verifica si no se han seleccionado géneros
    if (genres.length < 2 ) {
      console.log('Ningún género seleccionado');
      // Si no se ha seleccionado ningún género, devuelve todas las funciones sin filtrar
      return functions;

    } else{
        // Filtra las funciones que coinciden con al menos uno de los géneros seleccionados
        const functionsFiltered = functions.filter(func => {
          // Verifica si la función tiene al menos uno de los géneros seleccionados
          return func.genero && genres.some(genre => func.genero?.toLowerCase() === genre.toLowerCase());
      });
      return functionsFiltered;

    }
}


  return { functions, calcularCantidad, fetchFunctions, searchFunctionsPerId, deleteFunction, createFunction, editFunction, selectedFunction, formatoHora, formatoDia,formatoFecha, filterFunctionsByTitle, filterFunctionsByGenre };
});
