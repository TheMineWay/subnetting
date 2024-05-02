class I18n
{
    // Instantiator
    public static async Task<I18n> Create(string baseUrl)
    {
        // Read local storage
        Language language = Language.es_ES;

        // Fetch JSONs
        var jsonResponse = await new HttpClient().GetAsync($"{baseUrl}/i18n/locales/{GetLanguageCode(language)}.json");

        return new I18n();
    }

    private readonly Language language;
    private I18n(Language language = Language.es_ES)
    {
        this.language = language;
    }

    public Language GetLanguage() => language;

    // Text

    public string T(string key)
    {
        return key;
    }

    // STATIC

    public static string GetLanguageCode(Language language)
    {
        switch (language)
        {
            case Language.es_ES:
                return "es-ES";
        }
        return "es-ES";
    }
}

enum Language
{
    es_ES
}