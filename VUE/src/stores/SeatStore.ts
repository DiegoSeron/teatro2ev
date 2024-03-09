import { defineStore } from 'pinia';
import { ref, computed } from 'vue';
import axios from 'axios';




interface Butaca {
    obraId: number;
    butacaId: number;
    libre: boolean;

}

export const useSeatStore = defineStore('SeatStore', () => {
    // State
    const seats = ref<Array<Butaca>>([]);

    // Getter
    // calcula la cantidad de funciones que hay
    const calcularCantidad = computed(() => seats.value.length);

    // Action
    // busca en la api las butacas por id de la funcion
    async function fetchSeatsPerId(id: any) {
        try {
            const response = await axios.get(`http://localhost:5000/Seat/${id}`);
            console.log("Fetch para sacar butacas por obra id");
            seats.value = response.data;
            console.log(seats.value);

        } catch (error) {
            console.error('Error al hacer la petición:', error);
        }
    }

    return { seats, calcularCantidad, fetchSeatsPerId };
});

