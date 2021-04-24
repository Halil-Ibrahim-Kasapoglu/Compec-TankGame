using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TankGame.Network;
using UniRx;

namespace TankGame.UI
{
    public class MenuController : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _currentState;
        [SerializeField] private Button[] _networkButtons;
        [SerializeField] private TMP_InputField _inputField;
        private void Awake()
        {
             UpdateUIWithNetworkState(MatchmakingController.Instance.CurrentNetworkState);
            MessageBroker.Default.Receive<EventPlayerNetworkStateChange>().Subscribe(OnPlayerNetworkState).AddTo(gameObject);
            _inputField.onEndEdit.AddListener(OnEditEnd);
        }

        private void OnEditEnd(string arg0)
        {
            PhotonNetwork.playerName = arg0;
        }

        private void OnPlayerNetworkState(EventPlayerNetworkStateChange obj)
        {
            var networkState = obj.PlayerNetworkState;
            UpdateUIWithNetworkState(networkState);
        }

        private void UpdateUIWithNetworkState(PlayerNetworkState networkState)
        {
            _currentState.text = "Connetion state: " + networkState.ToString();
            for (int i = 0; i < _networkButtons.Length; i++)
            {
                _networkButtons[i].interactable = networkState == PlayerNetworkState.Connected;
            }
        }

        public void CreateRoomClick()
        {
            MatchmakingController.Instance.CreateRoom();
        }

        public void JoinRandomRoomClick()
        {
            MatchmakingController.Instance.JoinRandomRoom();
        }

        public void SettingsClick()
        {
            Debug.Log("Not implemented"); ;
        }
    }
}