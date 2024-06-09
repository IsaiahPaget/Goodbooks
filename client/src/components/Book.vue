<script setup lang="ts">
import { TBook } from '../Models/TBook';

defineProps<{book: TBook}>();
</script>

<template>
        <h3>
            {{ book.Title }}
        </h3>
        <p>
            {{ book.Author }}
        </p>
</template>

<style scoped>
</style>