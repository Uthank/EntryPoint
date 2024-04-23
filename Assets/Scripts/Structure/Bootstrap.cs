using System.Collections;
using UnityEngine;
using StateMachine = FiniteStateMachine.StateMachine;

namespace Structure
{
    public class Bootstrap : MonoBehaviour
    {
        private IEnumerator Start()
        {
#if UNITY_EDITOR == false
            yield return InitYandexSDK();
#endif
            
            StateMachine gameStateMachine = new StateMachine();
            gameStateMachine.Enter(new GameBootstrapState(gameStateMachine));
            yield break;
        }

        private IEnumerator InitYandexSDK()
        {
            yield return Agava.YandexGames.YandexGamesSdk.IsInitialized;
            
            bool isLoaded = false;
            Agava.YandexGames.Utility.PlayerPrefs.Load(() => isLoaded = true);

            while (isLoaded == false)
                yield return null;
        }
    }
}