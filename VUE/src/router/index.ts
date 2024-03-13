// router/index.js
import { createRouter, createWebHistory } from "vue-router";
import HomeView from "../views/HomeView.vue";
import FunctionsView from "../views/FunctionsView.vue";
import FunctionDescriptionView from "../views/FunctionDescriptionView.vue";
import SeatSelectorView from "../views/SeatSelectorView.vue";
import BuyView from "../views/BuyView.vue";
import AdminView from "../views/AdminView.vue";
import LoginView from "../views/LoginView.vue";
import { useLoginStore } from '../stores/LoginStore'; // Importa el store de autenticación



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
        }
        ,
        {
            // login de admin
            path: '/login',
            name: 'login',
            component: LoginView,
            props: true
        },
        {
            // menu de admin
            path: '/Admin',
            name: 'admin',
            component: AdminView,
            props: true,
            meta: { requiresAuth: true }, // Proteger la ruta con autenticación

        }
    ]
})

router.beforeEach((to, from, next) => {
    const loginStore = useLoginStore();
    
    // Verificar si la ruta es la página de inicio de sesión y si el usuario está autenticado
    if (to.name === 'login' && loginStore.user.isAuthenticated) {
        // Si el usuario ya está autenticado y trata de acceder a la página de inicio de sesión, redirigir a la página de administración
        next('/Admin');
    } else if (to.name === 'admin' && !loginStore.user.isAuthenticated) {
        // Si el usuario no está autenticado y trata de acceder a la página de administración, redirigir a la página de inicio de sesión
        next('/login');
    } else {
        // Permitir que la navegación continúe según la lógica actual
        next();
    }
});




export default router;
