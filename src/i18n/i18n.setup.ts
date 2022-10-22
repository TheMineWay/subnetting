import { createI18n } from 'vue-i18n';

type I18nLangOpts = {
    common: unknown;
}

export function i18nSetup() {

    const messages: {
        [key: string]: {
            message: I18nLangOpts,
        },
    } = {
        es: {
            message: {
                common: require('@/i18n/es/common/common.json'),
            },
        },
    };

    const i18n = createI18n({
        locale: 'es',
        fallbackLocale: 'es',
        messages,
    });

    return i18n;
}