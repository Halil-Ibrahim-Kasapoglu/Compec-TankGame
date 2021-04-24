using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TankGame.Stat
{
    public interface IPlayerStatHolder
    {
        PlayerStat PlayerStat { get; }
        void SetStat(PlayerStat stat);
    }
}