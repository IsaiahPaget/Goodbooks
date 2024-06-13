<script setup lang="ts">
import { TBook } from '../Models/TBook';

defineProps<{book: TBook}>();
</script>

<template>
        <h3>
            {{ book.title }}
        </h3>
        <p>
            {{ book.author }}
        </p>
</template>

<style scoped>
</style>