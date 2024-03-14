<template>
    <canvas ref="canvas" id="myCanvas" width="65" height="65"
        style=" border-radius: 50% ; background-color: white;"></canvas>
</template>
  
<script setup lang="ts">
import { ref, onMounted } from 'vue';
import MASK_R_URL from '@/assets/canvas/MASK_R_default.png'
import MASK_L_URL from '@/assets/canvas/MASK_L_default.png'
import TICKET_URL from '@/assets/canvas/TICKET_default.png'

const canvas = ref<HTMLCanvasElement | null>(null);

// Carga de las imágenes
const MASK_R = new Image();
MASK_R.src = MASK_R_URL; // Asigna la URL de la imagen a la propiedad src del objeto Image

const MASK_L = new Image();
MASK_L.src = MASK_L_URL;

const TICKET = new Image();
TICKET.src = TICKET_URL;

// Inicializa las posiciones y para las máscaras y el ticket
let maskRPosX = 70;
let maskLPosX = -28;
let ticketPosY = 60;

const animate = () => {
    if (canvas.value) {
        const ctx = canvas.value.getContext('2d');
        if (ctx) {
            // Limpia el canvas en cada fotograma para evitar arrastre
            ctx.clearRect(0, 0, canvas.value.width, canvas.value.height);

            // Dibuja las imágenes con las animaciones
            ctx.drawImage(MASK_R, maskRPosX, 16, 40, 40);
            ctx.drawImage(MASK_L, maskLPosX, 9, 40, 40);

            // Actualiza las posiciones para las animaciones
            if (maskRPosX > 25) {
                maskRPosX -= 1.5; // Reducimos la velocidad para un movimiento más suave
            }

            if (maskLPosX < 3) {
                maskLPosX += 1; // Reducimos la velocidad para un movimiento más suave
            }

            if (ticketPosY > 38) {
                ticketPosY -= 1; // Reducimos la velocidad para un movimiento más suave
            }

            // Dibuja el ticket después de que las máscaras hayan comenzado a aparecer
            ctx.drawImage(TICKET, 15, ticketPosY, 30, 19);

            // Solicita el próximo fotograma de animación
            requestAnimationFrame(animate);
        }
    }
};

// Asegurarse de que todas las imágenes estén cargadas antes de iniciar la animación
const imagesLoaded = () => {
    return MASK_R.complete && MASK_L.complete && TICKET.complete;
};

const startAnimation = () => {
    if (imagesLoaded()) {
        animate();
    } else {
        setTimeout(startAnimation, 100);
    }
};

onMounted(startAnimation);


</script>
  