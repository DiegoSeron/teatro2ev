<script setup lang="ts">
// defineProps<{
//   title?: string
//   description?: string
//   imageSrc?: string
//   diaObra?: string
//   obraId: number
//   }>()
import 'bootstrap/dist/js/bootstrap.bundle.min.js';
import CarouselFunction from './CarouselFunction.vue';


</script>

<template>
    <div id="carouselExample" class="carousel slide">
        <div class="carousel-inner">
            <div class="carousel-item active">
                <div>
                    <CarouselFunction  :obra-id=5 titulo="EL MAGO POP" imagen-src="el-mago-pop.jpg"/>
                </div>
            </div>
            <div class="carousel-item">
                <div>
                    <CarouselFunction :obra-id=6 titulo="El Rey Leon" imagen-src="ElReyLeon3Aniv200.jpg"/>

                </div>
            </div>
            <div class="carousel-item">
                <div>
                    <CarouselFunction :obra-id=7 titulo="FANGO" imagen-src="fango.jpg"/>

                </div>
            </div>
        </div>
        <button class="carousel-control-prev" type="button" data-bs-target="#carouselExample" data-bs-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Previous</span>
        </button>
        <button class="carousel-control-next" type="button" data-bs-target="#carouselExample" data-bs-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Next</span>
        </button>
    </div>
</template>


<style scoped lang="scss">
@import 'bootstrap/dist/css/bootstrap.min.css';

.carousel {
    margin-top: 50px;
    margin-bottom: 50px;

    .carousel-inner {
        padding-top: 60px;
        padding-bottom: 60px;
        background-color: #ba1313;

        .carousel-item div {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 250px;



        }
    }
}

/* PARA ORDENADORES */
@media screen and (min-width: 767px) {
    .carousel {


        .carousel-inner {

            .carousel-item div {
                display: flex;
                justify-content: center;
                align-items: center;
                height: 450px;
                margin-left: 50px;
                margin-right: 50px;

            }
        }
    }
}
</style>