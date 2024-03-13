<script setup lang="ts">
import { ref } from 'vue';
import { useLoginStore } from '@/stores/LoginStore';
import { useRouter } from 'vue-router';


const loginStore = useLoginStore();
const email = ref('');
const password = ref('');
const router = useRouter();


const login = () => {
    loginStore.login(email.value, password.value);
    router.push('/Admin');
};
</script>

<template>
    <form @submit.prevent="login">
        <input type="text" v-model="email" placeholder="Email">
        <input type="password" v-model="password" placeholder="Password">
        <button type="submit">Login</button>
    </form>
</template>

<style scoped lang="scss">
form {
    display: flex;
    flex-direction: column;
    align-items: center;
    margin-top: 20px;

    input {
        width: 300px;
        padding: 10px;
        margin-bottom: 10px;
        border: 1px solid #ccc;
        border-radius: 5px;
        font-size: 16px;

        &::placeholder {
            color: #aaa;
        }
    }

    button {
        width: 200px;
        padding: 10px;
        border: none;
        border-radius: 5px;
        background-color: #007bff;
        color: #fff;
        font-size: 18px;
        cursor: pointer;
        transition: background-color 0.3s ease;

        &:hover {
            background-color: #0056b3;
        }
    }
}
</style>