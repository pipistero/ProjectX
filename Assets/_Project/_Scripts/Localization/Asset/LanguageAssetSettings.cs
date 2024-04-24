using System;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

namespace Localization.Asset
{
    [Serializable]
    public class LanguageAssetSettings
    {
        [Title("Language")]
        [field: SerializeField, Required] public LanguageType Language { get; private set; }
        
        [Title("Font")]
        [field: SerializeField, Required] public TMP_FontAsset FontAsset { get; private set; }
        [field: SerializeField, Required] public float FontSizeMultiplier { get; private set; }
    }
}