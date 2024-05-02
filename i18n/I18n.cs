using Newtonsoft.Json.Linq;

class I18n
{
    // Instantiator
    public static async Task<I18n> Create(string baseUrl, bool disableCache = true)
    {
        // Read local storage
        Language language = Language.es_ES;

        // Fetch JSONs
        var jsonResponse = await new HttpClient().GetAsync($"{baseUrl}/i18n/locales/{GetLanguageCode(language)}.json{(disableCache ? ("?c=" + DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()) : "")}");

        var text = await jsonResponse.Content.ReadAsStringAsync() ?? throw new Exception();
        return new I18n(I18nTranslationFile.CreateFromString(text));
    }

    private readonly Language language;
    private readonly I18nTranslationFile i18nTranslationFile;
    private I18n(I18nTranslationFile translationFile, Language language = Language.es_ES)
    {
        this.language = language;
        i18nTranslationFile = translationFile;
    }

    public Language GetLanguage() => language;

    // Text

    public string T(string key)
    {
        return i18nTranslationFile.GetValue(key);
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

public class I18nTranslationFile
{
    public static I18nTranslationFile CreateFromString(string jsonString) => new I18nTranslationFile(JObject.Parse(jsonString));
    private readonly JObject json;
    public I18nTranslationFile(JObject json)
    {
        this.json = json;
    }

    public string GetValue(string route)
    {
        JToken? token = json;
        string[] keys = route.Split('.');

        foreach (var key in keys)
        {
            if (token?[key] == null) return route;

            token = token[key];
        }

        return token?.ToString() ?? "";
    }
}

enum Language
{
    es_ES
}