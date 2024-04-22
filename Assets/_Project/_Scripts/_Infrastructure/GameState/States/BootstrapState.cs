using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Infrastructure.GameState.Machine;
using Widgets.Controller;
using Zenject;

namespace Infrastructure.GameState.States
{
    public class BootstrapState : IState
    {
        private IGameStateMachine _gameStateMachine;
        private IWidgetsController _widgetsController;

        [Inject]
        private void Construct(IGameStateMachine gameStateMachine, IWidgetsController widgetsController)
        {
            _gameStateMachine = gameStateMachine;
            _widgetsController = widgetsController;
        }

        public async void Enter()
        {
            await InitializeSystems();
            _gameStateMachine.Enter<MenuState>();
        }

        public void Exit()
        {

        }

        private async UniTask InitializeSystems()
        {
            await _widgetsController.Initialize();
        }
    }
}