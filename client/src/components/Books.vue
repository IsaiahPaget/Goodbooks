<script setup lang="ts">
import { TBook } from '../Models/TBook';
import Book from './Book.vue';
import BookInput from './BookInput.vue';
import { ref, watch, watchEffect } from 'vue';

const Books = ref<TBook[]>([])

async function GetAllBooks() {
  console.log("getting books")
  const data = await fetch('https://localhost:7100/api/books')
  const books: TBook[] = await data.json()
  Books.value = books  
}
async function PostBook(book: TBook) {
  const result = await fetch("https://localhost:7100/api/books", {
    headers: {
      'Accept': 'application/json',
      'Content-Type': 'application/json'
    },
    method: "POST",
    body: JSON.stringify(book)
  })
  console.log(result)
}

async function myAction(book: TBook) {
  Books.value = [...Books.value,
    book
  ]
  await PostBook(book)
  await GetAllBooks()
}

GetAllBooks()

</script>

<template>
  <div class="container">
    <BookInput @on-submit="myAction" />
    <ul class="container">
      <li v-for="book in Books" :key="book.id" class="card">
        <Book :book="book" />
      </li>
    </ul>
  </div>
</template>

<style scoped>
</style>
