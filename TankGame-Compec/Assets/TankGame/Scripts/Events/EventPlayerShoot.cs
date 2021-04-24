using System.Collections;
using System.Collections.Generic;
using TankGame.Stat;
using UnityEngine;

namespace TankGame.Inventory
{
    public struct EventPlayerShoot
    {
        public Vector3 Origin;
        public PlayerStat Stat;
        public EventPlayerShoot(Vector3 origin, PlayerStat isLocal)
        {
            Origin = origin;
            Stat = isLocal;
        }
    }
}