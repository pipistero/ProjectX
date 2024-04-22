using Infrastructure.GameState.Machine;

namespace Infrastructure.GameState.Factory
{
    public interface IGameStateFactory
    {
        TState GetState<TState>() where TState : class, IExitableState;
    }
}