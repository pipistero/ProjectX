using Cysharp.Threading.Tasks;

namespace UI.Widgets.Animations
{
    public class EmptyWidgetAnimation : WidgetAnimation
    {
        public override UniTask AnimateOpen(Widget widget)
        {
            return UniTask.CompletedTask;
        }

        public override UniTask AnimateClose(Widget widget)
        {
            return UniTask.CompletedTask;
        }
    }
}