using Infrastructure.GameState.Machine;
using Infrastructure.GameState.States;
using Zenject;

namespace Infrastructure.Installers.GameState
{
    public class GameStatesInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            InstallStates();
        }

        private void InstallStates()
        {
            InstallState<BootstrapState>();
            InstallState<MenuState>();
        }

        private void InstallState<TState>() where TState : class, IExitableState
        {
            Container
                .BindInterfacesAndSelfTo<TState>()
                .AsSingle()
                .NonLazy();
        }
    }
}