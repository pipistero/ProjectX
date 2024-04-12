using Infrastructure.GameState.Factory;
using Infrastructure.GameState.Machine;
using NSubstitute;

namespace Tests.GameState
{
    public class Setup
    {
        public static IGameStateFactory GameStateFactory(IState state)
        {
            var gameStateFactory = Substitute.For<IGameStateFactory>();
            gameStateFactory.GetState<IState>().Returns(state);
            return gameStateFactory;
        }
    }
}