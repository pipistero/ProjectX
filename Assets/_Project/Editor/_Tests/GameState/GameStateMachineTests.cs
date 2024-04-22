using FluentAssertions;
using Infrastructure.GameState.Machine;
using NUnit.Framework;

namespace Tests.GameState
{
    public class GameStateMachineTests
    {
        [Test]
        public void WhenEnteringState_AndActiveStateIsDefault_ThenActiveStateShouldBeEnteredState()
        {
            //---ARRANGE---
            var state = Create.State();
            var gameStateFactory = Setup.GameStateFactory(state);
            var gameStateMachine = Create.GameStateMachine(gameStateFactory);

            //---ACT---
            gameStateMachine.Enter<IState>();
            
            //---ASSERT---
            gameStateMachine.ActiveState.Should().Be(state);
        }
    }
}