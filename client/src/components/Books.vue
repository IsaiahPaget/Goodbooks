<script setup lang="ts">
import { TBook } from '../Models/TBook';
import Book from './Book.vue';
import BookInput from './BookInput.vue';
import { ref } from 'vue';
const Books = ref([
  { Author: "hello", Title: "hello you"},
  { Author: "hello2", Title: "hello you2"}
])
const myAction = (book: TBook) => {
  Books.value = [...Books.value,
    {Author: book.Author, Title: book.Title}
  ]
}
</script>

<template>
  <div class="container">
    <BookInput @on-submit="myAction" />
    <ul class="container">
      <li v-for="book in Books" class="card">
        <Book :book="book" />
      </li>
    </ul>
  </div>
</template>

<style scoped>
</style>
