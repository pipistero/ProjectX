using Cysharp.Threading.Tasks;

namespace Widgets.Interfaces
{
    public interface IInitializedWidget
    {
        UniTask Initialize();
    }
}