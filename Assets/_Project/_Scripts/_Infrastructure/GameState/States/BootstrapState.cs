using Cysharp.Threading.Tasks;
using Infrastructure.GameState.Machine;
using Localization;
using Localization.Service;
using UI.Widgets.Controller;

namespace Infrastructure.GameState.States
{
    public class BootstrapState : IState
    {
        private readonly IGameStateMachine _gameStateMachine;
        private readonly IWidgetsController _widgetsController;
        private readonly ILocalizationService _localizationService;

        public BootstrapState(IGameStateMachine gameStateMachine, IWidgetsController widgetsController, ILocalizationService localizationService)
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
            await _localizationService.InitializeAsync(LanguageType.English);
        }
    }
}