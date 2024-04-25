using System;
using Cysharp.Threading.Tasks;
using Localization.Asset;

namespace Localization.Service
{
    public interface ILocalizationService
    {
        public event Action<LanguageAssetSettings> LanguageChanged;
        
        LanguageAssetSettings CurrentLanguageSettings { get; }

        UniTask InitializeAsync(LanguageType languageType);
        void ChangeLanguage(LanguageType language);
        string Get(string key);
    }
}