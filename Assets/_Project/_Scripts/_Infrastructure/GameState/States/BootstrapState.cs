using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Infrastructure.GameState.Machine;
using Localization.Service;
using Widgets.Controller;
using Zenject;

namespace Infrastructure.GameState.States
{
    public class BootstrapState : IState
    {
        private IGameStateMachine _gameStateMachine;
        private IWidgetsController _widgetsController;
        private ILocalizationService _localizationService;

        [Inject]
        private void Construct(IGameStateMachine gameStateMachine, IWidgetsController widgetsController, ILocalizationService localizationService)
        {
            _gameStateMachine = gameStateMachine;
            _widgetsController = widgetsController;
            _localizationService = localizationService;
        }

        public async void Enter()
        {
            await InitializeSystems();
            _gameStateMachine.Enter<MenuState>();
        }

        public void Exit()
        {

        }

        /// <summary>
        /// Here you can order systems initialization
        /// </summary>
        private async UniTask InitializeSystems()
        {
            await _widgetsController.InitializeAsync();
            await _localizationService.InitializeAsync();
        }
    }
}