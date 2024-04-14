using Widgets;
using Widgets.Controller;
using Zenject;

namespace _Infrastructure._Installers.Widgets
{
    public class WidgetsInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            InstallWidgets();
            InstallController();
        }

        private void InstallWidgets()
        {
            var widgets = FindObjectsOfType<Widget>();
            
            foreach (var widget in widgets)
            {
                InstallWidget(widget);
            }
        }

        private void InstallWidget(IWidget widget)
        {
            var type = widget.GetType();

            Container
                .BindInterfacesAndSelfTo(type)
                .FromInstance(widget)
                .AsSingle()
                .NonLazy();
        }

        private void InstallController()
        {
            Container
                .BindInterfacesAndSelfTo<WidgetsController>()
                .AsSingle();
        }
    }
}