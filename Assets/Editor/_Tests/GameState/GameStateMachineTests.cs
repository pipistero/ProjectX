using FluentAssertions;
using Infrastructure.GameState.Factory;
using Infrastructure.GameState.Machine;
using NSubstitute;
using NUnit.Framework;

namespace Tests.GameState
{
    public class GameStateMachineTests
    {
        [Test]
        public void WhenEnteringState_AndAllGood_ThenActiveStateShouldBeEnteredState()
        {
            //---ARRANGE---
            var state = Create.State();
            
            var gameStateFactory = Substitute.For<IGameStateFactory>();
            gameStateFactory.GetState<IState>().Returns(state);
            
            var gameStateMachine = Create.GameStateMachine(gameStateFactory);

            //---ACT---
            gameStateMachine.Enter<IState>();
            
            //---ASSERT---
            gameStateMachine.ActiveState.Should().Be(state);
        }
    }
}