import { createRouter, createWebHistory } from "vue-router";
import Books from "../components/Books.vue";

const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: [
        {
            path: "/",
            name: "books",
            component: Books
        },
    ]
})

export default router