import { Language } from "@/types/i18n/language.enum";
import { Translation } from "@/types/i18n/translation.enum";

// en_US
import en_US_common from "@/locales/en-US/common.json";
import en_US_main_page from "@/locales/en-US/pages/main.json";

export const languageResources: Record<
  Language,
  Record<Translation, object>
> = {
  [Language.en_US]: {
    [Translation.COMMON]: en_US_common,
    [Translation.MAIN_PAGE]: en_US_main_page,
  },
};
