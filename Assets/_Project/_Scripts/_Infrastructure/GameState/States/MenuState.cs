using Infrastructure.GameState.Machine;
using UI.Widgets.Controller;
using UI.Widgets.Test;

namespace Infrastructure.GameState.States
{
    public class MenuState : IState
    {
        private readonly IWidgetsController _widgetsController;

        public MenuState(IWidgetsController widgetsController)
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