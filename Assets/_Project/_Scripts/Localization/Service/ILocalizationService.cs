using System;
using Localization.Asset;

namespace Localization.Service
{
    public interface ILocalizationService
    {
        public event Action<LanguageAssetSettings> LanguageChanged;
        
        LanguageAssetSettings CurrentLanguageSettings { get; }
        
        string Get(string key);
    }
}