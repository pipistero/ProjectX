using Cysharp.Threading.Tasks;

namespace Widgets.Interfaces
{
    public interface IWidget
    {
        WidgetStatus Status { get; }
        
        UniTask OnOpen();
        UniTask Open();
        
        UniTask Close();
        UniTask OnClose();
    }
}