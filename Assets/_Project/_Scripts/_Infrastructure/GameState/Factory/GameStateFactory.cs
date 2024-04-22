using Infrastructure.GameState.Machine;
using Zenject;

namespace Infrastructure.GameState.Factory
{
    public class GameStateFactory : IGameStateFactory
    {
        private readonly DiContainer _container;

        public GameStateFactory(DiContainer container)
        {
            _container = container;
        }

        public TState GetState<TState>() where TState : class, IExitableState
        {
            return _container.Resolve<TState>();
        }
    }
}