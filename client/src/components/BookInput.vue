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
    if (book.title === "" || book.author === "") {
        return false
    }
    return true
}
function sendValuesUp(title: string, author: string) {
    const book: TBook = {
        id: 0,
        title: title,
        author: author,
        createdOn: "",
        updatedOn: ""
    }
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
        <button @click.prevent="sendValuesUp(Title, Author)" class="submit">
            <span>Submit</span>
        </button>
    </form>
</template>

<style scoped>
</style>