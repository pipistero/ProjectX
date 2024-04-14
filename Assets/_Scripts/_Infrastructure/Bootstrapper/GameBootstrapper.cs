using System;
using Infrastructure.GameState.Machine;
using Infrastructure.GameState.States;
using UnityEngine;
using Zenject;

namespace Infrastructure.Bootstrapper
{
    public class GameBootstrapper : MonoBehaviour
    {
        private IGameStateMachine _gameStateMachine;

        [Inject]
        private void Construct(IGameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }
        
        private void Awake()
        {
            _gameStateMachine.Enter<BootstrapState>();
        }
    }
}