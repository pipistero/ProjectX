using Cysharp.Threading.Tasks;

namespace Localization.Asset
{
    public interface ILanguageAsset
    {
        LanguageAssetSettings Settings { get; }

        UniTask Prepare();
        string Get(string key);
    }
}