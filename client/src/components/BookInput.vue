<script setup lang="ts">
import { ref } from 'vue';
import { TBook } from '../Models/TBook';
const Title = ref("")
const Author = ref("")
const emit = defineEmits(["onSubmit"])
function clearInputs() {
    Title.value = ""
    Author.value = ""
}
function validateInput(book: TBook): boolean {
    if (book.Title === "" || book.Author === "") {
        return false
    }
    return true
}
function sendValuesUp(book: TBook) {
    if (!validateInput(book)) {
        alert("Not Valid Input")
        return
    }
    emit('onSubmit', book)
    clearInputs()
}
</script>

<template>
    <form class="container card">
        <div>
            <label>Title</label>
            <input type="text" v-model="Title" required/>
        </div>
        <div>
            <label>Author</label>
            <input type="text" v-model="Author" required/>
        </div>
        <button @click.prevent="sendValuesUp({Title: Title, Author: Author})" class="submit">
            <span>Submit</span>
        </button>
    </form>
</template>

<style scoped>
</style>