using Infrastructure.GameState.Factory;
using Infrastructure.GameState.Machine;
using NSubstitute;

namespace Tests.GameState
{
    public class Create
    {
        public static IState State()
        {
            return Substitute.For<IState>();
        }

        public static GameStateMachine GameStateMachine(IGameStateFactory gameStateFactory)
        {
            return new GameStateMachine(gameStateFactory);
        }
    }
}