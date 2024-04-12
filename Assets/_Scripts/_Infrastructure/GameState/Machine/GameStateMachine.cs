using Infrastructure.GameState.Factory;

namespace Infrastructure.GameState.Machine
{
    public class GameStateMachine : IGameStateMachine
    {
        private readonly IGameStateFactory _gameStateFactory;

        public IExitableState ActiveState { get; private set; }

        public GameStateMachine(IGameStateFactory gameStateFactory)
        {
            _gameStateFactory = gameStateFactory;
        }
        
        public void Enter<TState>() where TState : class, IState
        {
            var state = ChangeState<TState>();
            state.Enter();
        }

        public void Enter<TState, TPayload>(TPayload payload) where TState : class, IPayloadedState<TPayload>
        {
            var state = ChangeState<TState>();
            state.Enter(payload);
        }

        private TState ChangeState<TState>() where TState : class, IExitableState
        {
            ActiveState?.Exit();

            var state = GetState<TState>();
            ActiveState = state;

            return state;
        }
        
        private TState GetState<TState>() where TState : class, IExitableState
        {
            return _gameStateFactory.GetState<TState>();
        }
    }
}