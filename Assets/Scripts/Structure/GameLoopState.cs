using FiniteStateMachine;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Structure
{
    internal class GameLoopState : IState
    {
        private readonly StateMachine _stateMachine;

        public GameLoopState(StateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }

        public void Enter()
        {
            AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("Game");
            asyncOperation.completed += _ => LoadHero();
        }

        public void Exit()
        {
        }

        private void LoadHero()
        {
            GameObject heroPrefab = Services.ResourceLoaderService.LoadPrefab("Hero");
            Hero hero = Object.Instantiate(heroPrefab, Vector3.zero, Quaternion.identity).GetComponent<Hero>();
            Services.InputService.SetActive(true);
            
            GameObject heroScoreHUD = Services.ResourceLoaderService.LoadPrefab("ScoreHUD");
            Object.Instantiate(heroScoreHUD, Vector3.zero, Quaternion.identity).GetComponent<ScoreHUD>().Init(hero);
        }
    }
}