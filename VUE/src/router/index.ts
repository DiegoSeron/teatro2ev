import { createRouter, createWebHistory } from "vue-router"
import HomeView from "../views/HomeView.vue"
import FunctionsView from "../views/FunctionsView.vue"
import FunctionDescriptionView from "../views/FunctionDescriptionView.vue"
import SeatSelectorView from "../views/SeatSelectorView.vue"
import BuyView from "../views/BuyView.vue"
import AdminView from "../views/AdminView.vue"


const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: [
        {
            // home page
            path: '/',
            name: 'home',
            component: HomeView
        },
        {
            // grid de funciones
            path: '/Obra',
            name: 'obras',
            component: FunctionsView
        },
        {
            // descripcion de funcion
            path: '/Obra/:id',
            name: 'obra',
            component: FunctionDescriptionView,
            props: true,
        },
        {
            // selector de butacas
            path: '/Butaca/:id',
            name: 'butaca',
            component: SeatSelectorView,
            props: true,
        },
        {
            // selector de butacas
            path: '/Compra',
            name: 'compra',
            component: BuyView,
            props: true,
        },
        {
            // menu de admin
            path: '/Admin',
            name: 'admin',
            component: AdminView,
            props: true,
        }
    ]
})

export default router