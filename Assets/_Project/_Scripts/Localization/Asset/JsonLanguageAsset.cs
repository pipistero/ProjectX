using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Unity.Plastic.Newtonsoft.Json;
using UnityEngine;

namespace Localization.Asset
{
    [CreateAssetMenu(menuName = "Localization/JsonLanguageAsset", fileName = "New JsonLanguageAsset")]
    public class JsonLanguageAsset : BaseLanguageAsset
    {
        public override UniTask Prepare()
        {
            _localizationMap = JsonConvert.DeserializeObject<Dictionary<string, string>>(_asset.text);
            
            return UniTask.CompletedTask;
        }
    }
}