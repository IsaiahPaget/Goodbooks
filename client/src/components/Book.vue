<script setup lang="ts">
defineProps<{Title: string, Author: string}>();
</script>

<template>
    <div class="card">
        <h3>
            {{ Title }}
        </h3>
        <p>
            {{ Author }}
        </p>
    </div>
</template>

<style scoped>
</style>