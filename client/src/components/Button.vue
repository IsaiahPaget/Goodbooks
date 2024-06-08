<script setup lang="ts">
defineProps<{class: string, text: string}>();
</script>

<template>
    <button @click="$emit('onClick')" :class='class'>
        <span>{{ text }}</span>
    </button>
</template>

<style scoped>
</style>