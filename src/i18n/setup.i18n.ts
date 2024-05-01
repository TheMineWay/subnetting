import { createInstance, i18n } from "i18next";
import { initReactI18next } from "react-i18next/initReactI18next";
import { i18nConfig } from "@/i18n/config.i18n";
import { Translation } from "@/types/i18n/translation.enum";
import { languageResources } from "@/i18n/language-resources";
import { Language } from "@/types/i18n/language.enum";

export default async function i18nSetup(
  locale: Language,
  namespaces: Translation[],
  i18nInstance?: i18n
) {
  i18nInstance = i18nInstance || createInstance();

  i18nInstance.use(initReactI18next);

  const resources = languageResources;

  await i18nInstance.init({
    lng: locale,
    resources,
    fallbackLng: i18nConfig.defaultLocale,
    supportedLngs: i18nConfig.locales,
    defaultNS: namespaces[0],
    fallbackNS: namespaces[0],
    ns: namespaces,
    preload: resources ? [] : i18nConfig.locales,
  });

  return {
    i18n: i18nInstance,
    resources: i18nInstance.services.resourceStore.data,
    t: i18nInstance.t,
  };
}
