import { defineStore } from 'pinia';

interface User {
    username: string;
    password: string;
    isAuthenticated: boolean; 
}

export const useLoginStore = defineStore('LoginStore', () => {
    // State
    const user: User = {
        username: '',
        password: '',
        isAuthenticated: false
    };

    function login(username: string, password: string) {
        debugger
        // Aquí puedes agregar la lógica para verificar las credenciales
            user.username = username;
            user.isAuthenticated = true;
            user.password = password;

    }

    function logout() {
        debugger
        user.isAuthenticated = false;
    }

    return { user, login, logout };
});
