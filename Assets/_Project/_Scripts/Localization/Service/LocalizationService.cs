using System;
using System.Collections.Generic;
using System.Linq;
using Cysharp.Threading.Tasks;
using Localization.Asset;
using UnityEngine;

namespace Localization.Service
{
    public class LocalizationService : ILocalizationService
    {
        public event Action<LanguageAssetSettings> LanguageChanged;
        
        public LanguageAssetSettings CurrentLanguageSettings => _currentAsset.Settings;
        
        private readonly List<ILanguageAsset> _assets;
        private ILanguageAsset _currentAsset;

        public LocalizationService(IEnumerable<ILanguageAsset> assets)
        {
            _assets = assets.ToList();
        }
        
        public async UniTask InitializeAsync(LanguageType languageType)
        {
            var assetsInitializationTasks = _assets
                .Select(a => a.Prepare())
                .ToList();

            await UniTask.WhenAll(assetsInitializationTasks);

            ChangeLanguage(languageType);
        }

        public void ChangeLanguage(LanguageType language)
        {
            if (CurrentLanguageSettings.Language == language)
                return;
            
            var asset = _assets.FirstOrDefault(a => a.Settings.Language == language);

            if (asset == null)
            {
                Debug.LogError($"[{nameof(LocalizationService)}] | Localization asset not found for language ({language})");
                return;
            }

            _currentAsset = asset;

            LanguageChanged?.Invoke(_currentAsset.Settings);
        }

        public string Get(string key)
        {
            if (_currentAsset.TryGet(key, out var result))
                return result;

            throw new Exception($"[{nameof(LocalizationService)}] | Localization value not found for key ({key}) in asset ({_currentAsset.Settings.Language})");
        }
    }
}