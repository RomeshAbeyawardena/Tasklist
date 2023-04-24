import { createApp } from 'vue'
import App from './App.vue'
import PrimeVue from 'primevue/config';
import { createPinia } from "pinia";
import "primevue/resources/themes/bootstrap4-dark-blue/theme.css";

createApp(App).use(PrimeVue, {
    ripple: true
}).use(createPinia())
.mount('#app')
