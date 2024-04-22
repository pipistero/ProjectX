using Infrastructure.GameState.Machine;
using Widgets.Controller;
using Widgets.Test;
using Zenject;

namespace Infrastructure.GameState.States
{
    public class MenuState : IState
    {
        private IWidgetsController _widgetsController;

        [Inject]
        private void Construct(IWidgetsController widgetsController)
        {
            _widgetsController = widgetsController;
        }

        public void Enter()
        {
            _widgetsController.Open<MenuWidget>();
        }

        public void Exit()
        {
            
        }
    }
}