using CodeBase.Services.Input;
using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class Game
    {
        public static IInputService InputService;
        public GameStateMachine _stateMachine;

        public Game()
        {
            _stateMachine = new GameStateMachine();
        }
    }
}