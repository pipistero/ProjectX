using Cysharp.Threading.Tasks;

namespace Utility.Loading
{
    public interface ILoadingCurtain
    {
        UniTask Open();
        UniTask Close();
    }
}