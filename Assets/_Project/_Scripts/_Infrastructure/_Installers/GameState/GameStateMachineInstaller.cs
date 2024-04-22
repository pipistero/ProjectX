using Infrastructure.GameState.Machine;
using Infrastructure.GameState.Factory;
using Zenject;

namespace Infrastructure.Installers.GameState
{
    public class GameStateMachineInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            InstallStateFactory();
            InstallStateMachine();
        }

        private void InstallStateFactory()
        {
            Container
                .BindInterfacesAndSelfTo<GameStateFactory>()
                .AsSingle();
        }

        private void InstallStateMachine()
        {
            Container
                .BindInterfacesAndSelfTo<GameStateMachine>()
                .AsSingle();
        }
    }
}