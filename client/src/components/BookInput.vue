<script setup lang="ts">
import Button from './Button.vue'
const handleSubmit = () => {
    console.log("stuff")
}
</script>

<template>
    <form class="container card">
        <div>
            <p>Title</p>
            <input />
        </div>
        <div>
            <p>Author</p>
            <input />
        </div>
        <Button @on-click="handleSubmit" class="submit" text="submit"/>
    </form>
</template>

<style scoped>
</style>