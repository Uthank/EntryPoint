namespace Localization
{
    public interface ILocalizationService
    {
        public Language CurrentLanguage { get; }
    
        public void ChangeLanguage(string i18NLang);
        public string GetLocalizedString(string key);
    }
}