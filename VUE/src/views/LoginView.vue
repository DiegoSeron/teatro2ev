<script setup lang="ts">
import { onMounted, ref } from 'vue';
import { useLoginStore } from '@/stores/LoginStore';

import { useRouter } from 'vue-router';
const loginStore = useLoginStore();
const username = ref('');
const password = ref('');
const router = useRouter();


onMounted(() => {
    loginStore.fetchUsers();
});

const login = () => {
    loginStore.login(username.value, password.value);
    router.push('/Admin')
};


</script>

<template>
    <div>
        <form @submit.prevent="login">
            <input type="text" v-model="username" placeholder="User name">
            <input type="password" v-model="password" placeholder="Password">
            <button type="submit">Login</button>
        </form>
    </div>
</template>


<style scoped lang="scss">
div {
    height: 66vh;

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
}
</style>