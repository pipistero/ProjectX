using Cysharp.Threading.Tasks;

namespace Widgets.Interfaces
{
    public interface IWidget
    {
        WidgetStatus Status { get; }

        UniTask Open();
        UniTask Close();
    }
}