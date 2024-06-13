<script setup lang="ts">
import { ref } from 'vue';
import { TQuizPreview } from '../../Models/TQuizPreview';
const quizzes = ref<TQuizPreview[]>([])
const filteredquizzes = ref<TQuizPreview[]>([])
const searchTerm = ref("")

function filterQuizzes() {
    const values = quizzes.value

}
</script>

<template>
    <div>
        <label>
            Search for quiz
        </label>
        <input v-model.trim="searchTerm" type="text" placeholder="search for quiz" @blur="filterQuizzes"/>
    </div>
    <div >
        
    </div>
</template>

<style scoped>
</style>