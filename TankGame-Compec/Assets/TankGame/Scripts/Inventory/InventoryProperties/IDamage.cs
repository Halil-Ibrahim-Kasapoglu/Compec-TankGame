using System.Collections;
using System.Collections.Generic;
using TankGame.Stat;
using UnityEngine;


namespace TankGame.Inventory
{
    public interface IDamage
    {
        float Damage { get; }
        float ArmorPenetration { get; }

        float TimedBaseDamageDuration { get; }
        float TimedBaseDamage { get; }
     
        PlayerStat Stat { get; }
    }
}