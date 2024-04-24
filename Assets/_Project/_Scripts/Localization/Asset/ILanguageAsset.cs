using Cysharp.Threading.Tasks;

namespace Localization.Asset
{
    public interface ILanguageAsset
    {
        LanguageAssetSettings Settings { get; }

        UniTask Prepare();
        bool TryGet(string key, out string result);
    }
}