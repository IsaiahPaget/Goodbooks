<script setup lang="ts">
import Book from './Book.vue';
import BookInput from './BookInput.vue';
const Books = [
  { Author: "hello", Title: "hello you"},
  { Author: "hello2", Title: "hello you2"}
]
</script>

<template>
  <div class="container">
    <BookInput />
    <Book v-for="book in Books" :Author='book.Author' :Title='book.Title'/>
  </div>
</template>

<style scoped>
</style>
