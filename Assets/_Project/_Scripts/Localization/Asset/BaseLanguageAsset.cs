using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Localization.Asset
{
    public abstract class BaseLanguageAsset : ScriptableObject, ILanguageAsset
    {
        [Title("Settings")]
        [field: SerializeField, Required] public LanguageAssetSettings Settings { get; private set; }

        [Title("Asset")] 
        [SerializeField, Required] protected TextAsset _asset;

        protected Dictionary<string, string> _localizationMap;

        public abstract UniTask Prepare();

        public bool TryGet(string key, out string result)
        {
            return _localizationMap.TryGetValue(key, out result);
        }
    }
}