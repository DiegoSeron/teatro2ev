<script setup lang="ts">
import { ref } from 'vue';
import IconTeather from './icons/IconTeather.vue'
import IconUser from './icons/IconUser.vue'
import IconCart from './icons/IconCart.vue'
import IconHamburguer from './icons/IconHamburguer.vue'
import IconLogoCanvas from './icons/IconLogoCanvas.vue';

const isMenuOpen = ref(false);

const toggleMenu = () => {
  isMenuOpen.value = !isMenuOpen.value;
};
</script>

<template>
  <div class="containerLogo">
    <IconLogoCanvas />
  </div>

  <nav class="nav">
    <div class="navegation" :class="{ 'mostrando': isMenuOpen }" id="navegation">
      <ul>
        <RouterLink to="/"><li><a>INICIO</a></li></RouterLink>
        <RouterLink to="/Obra"><li><a>FUNCIONES</a></li></RouterLink>
        <li><a href="#">INFORMACION</a></li>
        <li><a href="#">CONTACTO</a></li>
      </ul>
    </div>
    <div class="icons">
      <ul>
        <li>
          <RouterLink to="/Admin">
            <IconUser />
          </RouterLink>
        </li>
        <li>
          <IconCart />
        </li>
        <li>
          <IconHamburguer @click="toggleMenu" />
        </li>
      </ul>
    </div>
  </nav>
</template>

<style>
@charset "UTF-8";
@import url("https://fonts.googleapis.com/css2?family=Bebas+Neue&display=swap");

body {
  background-color: white;
  text-align: center;
  padding: 0px;
  margin: 0px;
}

a:-webkit-any-link {
    text-decoration: none !important;
}


header {
  width: 100%;
  height: 75px;
  display: flex;
  flex-direction: row;
  background-color: #ba1313;
}

header nav {
  height: auto;
  width: 75%;
  display: flex;
  flex-direction: row;
}

.containerLogo {
  display: flex;
  align-items: center;
  justify-content: center;
  height: auto;
  width: 25%;
}

.containerLogo img {
  width: 70px;
}

.mostrando {
  display: flex;
  justify-content: center;
  align-items: center;
}

.navegation {
  height: auto;
  width: 65%;
  font-family: "Bebas Neue";
}

.navegation ul {
  justify-content: center;
  list-style: none;
  display: flex;
  flex-direction: row;
}

.navegation ul li {
  margin-left: 20px;
  margin-right: 20px;
}

.navegation ul li a {
  font-size: 30px;
  text-decoration: none;
  color: white;
  transition: all 300ms;
}

.navegation ul li a:hover {
  font-size: 35px;
}

.icons {
  display: flex;
  flex-direction: row;
  justify-content: right;
  align-items: center;
  width: 35%;
}

.icons ul {
  display: flex;
  list-style: none;
  align-items: center;
}

.icons ul .icons__hamburguer {
  display: none;
  cursor: pointer;
}

.icons ul .icons__cart {
  cursor: pointer;
}

.icons ul .icons__user {
  cursor: pointer;
}

.icons img {
  width: 50px;
  margin-right: 20px;
}

@media screen and (max-width: 767px) {

  /* Agrega estilos para el menú cuando esté visible */
  .navegation {
    border-bottom: 2px solid black;
    position: absolute;
    top: 0;
    right: 0;
    width: 100%;
    height: auto;
    background-color: rgba(186, 19, 19, 0.9);
    /* Color de fondo */
    z-index: 1000;
    /* Asegura que esté por encima del resto del contenido */
  }

  .navegation ul {
    z-index: 1001;
    flex-direction: column;
  }

  .navegation ul li {
    z-index: 1002;
  }

  .navegation ul li a {
    z-index: 1003;
  }

  .mostrando {
    display: none;
  }

  .mostrar {
    display: block;
  }

  .icons {
    width: 100%;
  }

  .icons ul {
    z-index: 1000;
  }

  .icons ul .icons__hamburguer {
    display: block;
  }

  .icons ul .icons__cart {
    display: none;
  }

  .icons ul .icons__user {
    display: none;
  }
}

/*# sourceMappingURL=header.css.map */
</style>