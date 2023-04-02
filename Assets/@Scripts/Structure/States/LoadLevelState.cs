using Helix.Factory;
using UnityEngine;

namespace Helix.State
{
    public class LoadLevelState : IPayLoadState<string>
    {
        private readonly IGameFactory _gameFactory;

        private readonly GameStateMachine _gameStateMachine;

        public LoadLevelState(GameStateMachine gameStateMachine, IGameFactory gameFactory)
        {
            _gameFactory = gameFactory;
            _gameStateMachine = gameStateMachine;
        }

        public void Enter(string sceneName)
        {
            OnLoaded();
        }

        public void Exit()
        {
        }

        private void OnLoaded()
        {
            InitGameWrold();

            _gameStateMachine.Enter<GameLoopState>();
        }

        private void InitGameWrold()
        {
            InitTower();
        }

        private GameObject InitTower() => _gameFactory.CreatTower(Vector2.zero);
    }
}