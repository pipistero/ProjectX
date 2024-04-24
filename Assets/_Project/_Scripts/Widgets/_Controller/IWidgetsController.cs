using Cysharp.Threading.Tasks;
using Widgets.Interfaces;

namespace Widgets.Controller
{
    public interface IWidgetsController
    {
        UniTask InitializeAsync();
        
        TWidget GetWidget<TWidget>() where TWidget : class, IWidget;
        
        UniTask<TWidget> Open<TWidget>() where TWidget : class, IWidget;
        UniTask<TWidget> Close<TWidget>() where TWidget : class, IWidget;
    }
}