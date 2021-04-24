using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UniRx;
using TankGame.Network;

namespace TankGame
{
    [CreateAssetMenu(menuName = "Tank Game/Manager/Scriptable Scene Manager")]
    public class ScriptableSceneManager : AbstractScriptableManager<ScriptableSceneManager>
    {

        [SerializeField] private string _menuScene;
        [SerializeField] private string _gameScene;
        public override void Initialize()
        {
            base.Initialize();
            SceneManager.LoadScene(_menuScene);
            MessageBroker.Default.Receive<EventPlayerNetworkStateChange>().Subscribe(OnPlayerNetworkState).AddTo(_compositeDisposable);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }


        public override void Destroy()
        {
            base.Destroy();
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }

        private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
        {
            MessageBroker.Default.Publish(new EventSceneLoaded(arg0.name));
        }

        private void OnPlayerNetworkState(EventPlayerNetworkStateChange obj)
        {
            //when network state change
            Debug.Log("NETWORK STATE CHANGE ON SCENE MANAGER TO : " + obj.PlayerNetworkState);

            if (obj.PlayerNetworkState == PlayerNetworkState.Offline) {

            }
            else if (obj.PlayerNetworkState == PlayerNetworkState.Connecting)
            {

            }else if (obj.PlayerNetworkState == PlayerNetworkState.Connected)
            {

            }else if (obj.PlayerNetworkState == PlayerNetworkState.JoiningRoom)
            {

            }else if (obj.PlayerNetworkState == PlayerNetworkState.LeavingRoom)
            {
                SceneManager.LoadScene(_menuScene);

            }else if (obj.PlayerNetworkState == PlayerNetworkState.InRoom)
            {
                PhotonNetwork.isMessageQueueRunning = false;
                SceneManager.LoadScene(_gameScene);
            }else
            {

            }
        }
    }
}