using Cysharp.Threading.Tasks;

namespace Widgets
{
    public interface IInitializedWidget
    {
        UniTask Initialize();
    }
}