import { createApp } from "vue";
import App from "./App.vue";
import "./registerServiceWorker";
import router from "./router";

import BalmUI from 'balm-ui'; // Official Google Material Components
import 'balm-ui-css';
import { i18nSetup } from "./i18n/i18n.setup";

const i18n = i18nSetup();

createApp(App)
    .use(i18n)
    .use(BalmUI)
    .use(router)
    .mount("#app");
