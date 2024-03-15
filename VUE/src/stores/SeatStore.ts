import { defineStore } from 'pinia';
import { ref, computed, reactive } from 'vue';




interface Butaca {
    obraId?: number;
    butacaId?: number;
    libre: boolean;
}



export const useSeatStore = defineStore('SeatStore', () => {
    // State
    const seats = reactive<Array<Butaca>>([]);

    // Getter
    // calcula la cantidad de funciones que hay
    const calcularCantidad = computed(() => seats.length);

    // calcula la cantidad de butacas libres hay por obra
    const freeSeatsPerId = computed(() => {
        return seats.filter(seat => seat.libre === true).length;
    });

    // array de butacas que se selecciona (solo coje el id)
    const choosenSeats = ref<number[]>([]);

    // se añade al array choosenSeats la butaca seleccionada
    function onChooseSeat(butacaId: number) {
        console.log(`Se selecciona la butaca ${butacaId}`);
        // Agregar el asiento seleccionado al array
        choosenSeats.value.push(butacaId);
        console.log('butacas en el array choosenSeats'+choosenSeats.value);
    }
    
    // se elimina del array choosenSeats la butaca seleccionada
    function onUnchooseSeat(butacaId: number) {
        console.log(`Se deselecciona la butaca ${butacaId}`);
        // Filtrar el array para eliminar la butaca deseleccionada
        choosenSeats.value = choosenSeats.value.filter(seatId => seatId !== butacaId);
        console.log(choosenSeats.value);
    }

    // eliminar las butacas seleccionadas al cancelar o pagar
    function deleteSeats(){
        choosenSeats.value.splice(0, choosenSeats.value.length)
    }
    

    // Action
    // busca en la api las butacas por id de la funcion
    async function fetchSeatsPerId(id: any) {
        try {
            const response = await fetch(`http://localhost:5000/Seat/${id}`);
            console.log("Fetch para sacar butacas por obra id");

            const data = await response.json();
            seats.splice(0, seats.length)
            seats.push(...data);



        } catch (error) {
            console.error('Error al hacer la petición:', error);
        }
    }



    // ver cuantas butacas quedan libres


    // seleccionar butacas
    async function selectSeats(idFunction: number, idSeat: number, editSeat: Butaca) {

        try {
            const response = await fetch(`http://localhost:5000/Seat/${idFunction}/${idSeat}`, {
                method: 'PUT',
                headers: {
                    'Content-Type': 'application/json', // Indica que estás enviando datos en formato JSON
                },
                body: JSON.stringify(editSeat), // Convierte el objeto obra a JSON y lo envía en el cuerpo de la solicitud

            });
            if (response.ok) {
                console.log('butaca editada exitosamente.');
            } else {
                console.error('Error al editar la butaca:', response.statusText);
            }

        } catch (error) {
            console.error('Error al hacer la petición:', error);
        }
    }

    return { seats, calcularCantidad, freeSeatsPerId, choosenSeats, fetchSeatsPerId, selectSeats, onChooseSeat, onUnchooseSeat, deleteSeats};
});

