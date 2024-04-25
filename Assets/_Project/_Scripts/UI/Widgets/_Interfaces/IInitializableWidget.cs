using Cysharp.Threading.Tasks;

namespace UI.Widgets.Interfaces
{
    public interface IInitializedWidget
    {
        UniTask Initialize();
    }
}