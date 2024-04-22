using Sirenix.Utilities;
using Widgets;
using Widgets.Controller;
using Widgets.Interfaces;
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
            widgets.ForEach(InstallWidget);
        }

        private void InstallWidget(IWidget widget)
        {
            Container
                .BindInterfacesAndSelfTo(widget.GetType())
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