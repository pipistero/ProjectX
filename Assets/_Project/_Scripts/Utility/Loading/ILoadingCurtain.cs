using Cysharp.Threading.Tasks;

namespace Utility.Loading
{
    // TODO: Implement basic loading curtain
    public interface ILoadingCurtain
    {
        UniTask Open();
        UniTask Close();
    }
}