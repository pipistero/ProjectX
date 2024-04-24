using System;
using UnityEngine;

namespace Localization.Asset
{
    /// <summary>
    /// Language asset settings like font, font size multiplier etc.
    /// </summary>
    [Serializable]
    public class LanguageAssetSettings
    {
        [field: SerializeField] public LanguageType Language { get; private set; }
    }
}