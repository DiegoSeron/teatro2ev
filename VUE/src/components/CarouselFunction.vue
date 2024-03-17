<script setup lang="ts">
const props = defineProps<{
    obraId: number
    titulo: string
    imagenSrc: string
}>()



</script>

<template>
    <div class="info">
        <h1>{{ props.titulo }}</h1>
        <RouterLink :to="'/Obra/' + obraId" class="cardFunction__button">
            VER MÁS
        </RouterLink>
    </div>
    <div class="containerImg">
        <img :src="'src/assets/IMAGENES/' + imagenSrc" class="d-block w-100" alt="...">
    </div>
</template>

<style scoped lang="scss">
.info {
    width: 20%;
    display: flex;
    flex-direction: column;
    margin-right: 50px;

    h1 {
        font-family: "Bebas Neue";
        color: #ffffff !important;
        font-size: 50px;
    }
}

.containerImg {
    width: 30%;
    height: 90%;

    img {
        width: 100%;
        height: auto;
        border-radius: 15px;
    }
}

/* PARA ORDENADORES */
@media screen and (min-width: 767px) {


    .info {
        width: 20%;
        display: flex;
        flex-direction: column;

        h1 {
            font-family: "Bebas Neue";
            color: #ffffff !important;
            font-size: 80px;
        }
        
        .cardFunction__button{
            padding: 20px;
        }
    }

    .containerImg {
        width: 15%;
        height: 90%;

        img {
            width: 100%;
            height: auto;
            border-radius: 15px;
        }
    }
}
</style>