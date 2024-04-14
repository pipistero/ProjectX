using Cysharp.Threading.Tasks;

namespace Widgets
{
    public interface IWidget
    {
        WidgetStatus Status { get; }

        UniTask Open();
        UniTask Close();
    }
}