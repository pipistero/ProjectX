using Cysharp.Threading.Tasks;

namespace Widgets.Controller
{
    public interface IWidgetsController
    {
        UniTask Initialize();
        
        TWidget GetWidget<TWidget>() where TWidget : class, IWidget;
        
        UniTask<TWidget> Open<TWidget>() where TWidget : class, IWidget;
        UniTask<TWidget> Close<TWidget>() where TWidget : class, IWidget;
    }
}