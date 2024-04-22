using InteractiveObjects;
using InteractiveObjects.Casino;
using Zenject;

namespace _Infrastructure._Installers.Interactive
{
    public class InteractiveInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            InstallInteractive<CasinoInteractive>();
        }

        private void InstallInteractive<TInteractive>() where TInteractive : IInteractive
        {
            Container
                .Bind<TInteractive>()
                .AsSingle()
                .NonLazy();
        }
    }
}