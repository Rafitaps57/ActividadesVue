import { createApp } from 'vue'
// @ts-ignore App.vue is a Vue single-file component and may not have declarations configured.
import App from './App.vue'
// @ts-ignore The router module is JavaScript and does not provide type declarations.
import router from './router' 

const app = createApp(App)

app.use(router) 
app.mount('#app') 