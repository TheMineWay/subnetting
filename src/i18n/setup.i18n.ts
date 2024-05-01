import i18n from "i18next";
import { initReactI18next } from "react-i18next";
import { languageResources } from "@/i18n/language-resources";

i18n.use(initReactI18next).init({
  resources: languageResources,
  fallbackLng: "en",
  interpolation: {
    escapeValue: false,
  },
});
