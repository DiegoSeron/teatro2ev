<script setup lang="ts">
import CardComingSoon from '@/components/CardComingSoon.vue';
import CardInformation from '@/components/CardInformation.vue';
import Carousel from '@/components/Carousel.vue';
import { useFunctionStore } from '@/stores/FunctionStore';



</script>



<template>
  <section class="content">

    <Carousel />
  </section>
  <section class="content__gray">
    <div class="title">
      <h2>PRÓXIMAS FUNCIONES</h2>
    </div>
    <div class="articlesFunction">
      <CardComingSoon title="Campeones" imageSrc="campeones.jpg" dia-obra="30/03/2024" :obraId="4" />
      <CardComingSoon title="Don Juan" imageSrc="donjuan.jpg" dia-obra="16/02/2024" :obraId="1" />
    </div>
  </section>
  <section class="content">
    <div class="title">
      <h2>INFORMACIÓN DE INTERES</h2>
    </div>
    <div class="articlesInformation">
      <CardInformation title="HORARIOS DE TAQUILLA" plusClass="taquilla"/>
      <CardInformation title="NUESTRO TEATRO" plusClass="teatro"/>
      <CardInformation title="MEDIDAS DE PROTECCIÓN" plusClass="proteccion"/>
    </div>
  </section>
</template>


<style scoped lang="scss">
@import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@400;700&display=swap');
@import url('https://fonts.googleapis.com/css2?family=Bebas+Neue&display=swap');

$primaryColor: #ba1313;
$primaryFont: 'Bebas Neue';
$secondlyFont: 'Montserrat';

@mixin content($colorFondo) {
    background-color: $colorFondo;
    width: 100%;
    height: auto;
    display: flex;
    flex-direction: column;
    overflow: hidden;
    position: relative;

}

@mixin title {
    background-color: $primaryColor;
    color: white;
    text-decoration: none;
    height: auto;

    h2 {
        font: {
            family: $primaryFont;
            size: 30px;
        }
    }
}

@mixin card($width, $height) {
    background-color: $primaryColor;
    width: $width;
    height: $height;

    margin: {
        right: 6%;
        left: 6%;
        top: 3%;
        bottom: 3%;
    }

    border-radius: 15px 15px 5px 5px;

    padding: {
        top: 17px;
        bottom: 17px;
    }

    display: flex;
    flex-direction: column;
    justify-content: space-evenly;
    align-items: center;
    cursor: default;

}

@mixin footerDivs {
    width: 33%;
    height: 150px;
    border: 1px solid black;

    margin: {
        top: 15px;
        bottom: 15px;
    }

    display: flex;
    flex-direction: column;
}

body{
    text-align: center !important;
}

.content {
    @include content(white)
}

.content__gray {
    @include content(#D9D9D9)
}


// CONTENIDO
.title {
    @include title()
}

// ARTICULOS DE FUNCIONES
.articlesFunction {
    height: 75%;
    display: flex;
    flex-flow: row wrap;
    justify-content: center;
    align-items: center;
    flex-grow: 1;
    padding: {
        top: 60px;
        bottom: 60px;
    } 

    @media screen and (max-width: 767px) {
        flex-flow: row;

    }

}


// CORRUSEL

.carousel{
    margin: {
        top: 50px;
        bottom: 50px;
    }
}

.carousel-inner{

padding: {
    top: 60px;
    bottom: 60px;
}
    
background-color: $primaryColor;
    .carousel-item{
        div{
            display: flex;
            justify-content: center;
            align-items: center;
            height: 350px;
            margin: {
                left: 50px;
                right: 50px;
            } 

            .info{
                width: 20%;
                display: flex;
                flex-direction: column;


                h1{
                    font-family: $primaryFont;
                    color: #ffffff !important;
                    font-size: 80px;
                }
                
            }

            .containerImg{
                width: 15%;
                height: 90%;

                img{
                    width: 100%;
                    height: auto;
                    border-radius: 15px;
                    
                }
            }


        }
    }
}

// ARTICULOS DE INFORMACION
.articlesInformation {
    height: 75%;
    display: flex;
    flex-flow: row wrap;
    justify-content: center;
    align-items: center;
    padding: 60px;

}

// CARTAS DE FUNCION
.cardFunction {
    @include card(350px, 550px);

    .cardFunction__img {
        width: 90%;
        height: 65%;

        img {
            width: 100%;
            height: 100%;
            border-radius: 15px;

        }
    }

    .cardFunction__text {
        width: 90%;
        color: white;
        text-align: left;

        font: {
            family: $primaryFont;
            size: 18px;
        }

        h2 {
            margin: 0;
            padding: 0;
        }

        h3 {
            margin: 0;
            padding: 0;
        }

        display: flex;
        flex-direction: column;
        justify-content: left;
        align-items: left;
    }



    // TAMAÑO MOVIL
    @media screen and (max-width: 767px) {
        @include card(250px, 250px);
        margin: 5%;

        position: relative;

        .cardFunction__text {
            padding: {
                top: 6px;
                bottom: 6px;
            }
            font: {
                size: 16px;
            }
        }

        .cardFunction__button {
            text-align: center;

            font: {
                size: 9px;
            }

        }

    }
}

.cardFunction__button {
    color: $primaryColor;
    text-decoration: none;

    display: flex;
    justify-content: center;
    align-items: center;

    font: {
        family: $secondlyFont;
        size: 18px;
        weight: bold;
    }

    border: 0;
    border-radius: 50px;
    width: 90%;
    height: 10%;
    background-color: white;
    cursor: pointer;

}

// CARTA DE INFORMACION
.cardInformation {
    @include card(350px, 450px);
    cursor: pointer;

    .cardInformation__img {
        width: 90%;
        height: 65%;
        border-radius: 15px;
        background-size: cover;
        background-position: center;
        
    }

    .taquilla{
        background-image: url('../../IMAGENES/Rectangle\ 208.png');
    }

    .teatro{
        background-image: url('../../IMAGENES/teatro.png');

    }
    .proteccion{
        background-image: url('../../IMAGENES/proteccion.png');
    }

    .cardInformation__text {
        width: 90%;
        height: auto;
        color: white;

        font: {
            family: $primaryFont;
        }

        display: flex;
        flex-direction: column;
        justify-content: left;
        align-items: left;
    }


    @media screen and (max-width: 767px) {
        @include card(150px, 250px);


    }
}

</style>