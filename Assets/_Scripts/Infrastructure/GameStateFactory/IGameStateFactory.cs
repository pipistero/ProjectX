using Infrastructure.GameStateMachine;

namespace Infrastructure.GameStateFactory
{
    public interface IGameStateFactory
    {
        TState GetState<TState>() where TState : class, IExitableState;
    }
}