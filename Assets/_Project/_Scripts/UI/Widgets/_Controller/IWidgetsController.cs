using Cysharp.Threading.Tasks;
using UI.Widgets.Interfaces;

namespace UI.Widgets.Controller
{
    public interface IWidgetsController
    {
        UniTask InitializeAsync();
        
        TWidget GetWidget<TWidget>() where TWidget : class, IWidget;
        
        UniTask<TWidget> Open<TWidget>() where TWidget : class, IWidget;
        UniTask<TWidget> Close<TWidget>() where TWidget : class, IWidget;
    }
}