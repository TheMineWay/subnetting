import { createApp } from "vue";
import App from "./App.vue";
import "./registerServiceWorker";
import router from "./router";

import BalmUI from 'balm-ui'; // Official Google Material Components
import 'balm-ui-css';

createApp(App)
    .use(BalmUI)
    .use(router)
    .mount("#app");
