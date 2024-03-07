<script setup lang="ts">
defineProps<{
    titleInput: string
    typeInput: string
    classInput: string
    placeholderInput: string
}>()

</script>

<template>
    <div>
        <label>{{titleInput}}</label>
        <input :type=typeInput  :class= classInput :placeholder=placeholderInput>
    </div>
</template>

<style scoped lang="scss">
@import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@400;700&display=swap');
 @import url('https://fonts.googleapis.com/css2?family=Bebas+Neue&display=swap');
 @import url('https://fonts.googleapis.com/css?family=Merryweather');


 $primaryColor: #ba1313;
 $primaryFont: 'Bebas Neue';
 $secondFont: 'Montserrat';
 $thirdFont: 'Merryweather';
div {

    margin: 5px;
    display: flex;
    flex-direction: column;

    font-family: $secondFont;

    input {

        border: 2px solid #000000;
        border-radius: 50px;

        padding: {
            bottom: 10px;
            top: 10px;
            right: 100px;
        }

        margin: {
            top: 5px;
            bottom: 15px;
        }
    }

}
</style>