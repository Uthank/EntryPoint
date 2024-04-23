using System;
using UnityEngine;

namespace Localization
{
    public class LocalizationService : ILocalizationService
    {
        public Language CurrentLanguage { get; private set; } = Language.Ru;

        public LocalizationService()
        {
            Debug.Log("LocalizationService created");
        }
        
        public void ChangeLanguage(string language)
        {
            CurrentLanguage = language switch
            {
                "ru" => Language.Ru,
                _ => Language.En,
            };
        }

        public string GetLocalizedString(string key)
        {
            return String.Empty;
        }
    }
}