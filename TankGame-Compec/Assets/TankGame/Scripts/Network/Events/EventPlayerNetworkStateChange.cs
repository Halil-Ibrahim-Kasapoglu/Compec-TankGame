using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame.Network
{
    public struct EventPlayerNetworkStateChange
    {

        public EventPlayerNetworkStateChange(PlayerNetworkState playerNetworkState) {

            PlayerNetworkState = playerNetworkState;
        }

        public PlayerNetworkState PlayerNetworkState;
    }
}