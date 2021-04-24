using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TankGame.Inventory;


namespace TankGame.Stat
{
    public static class DamageableHelper
    {
        public static Dictionary<int , IDamagable> DamageableList = new Dictionary<int , IDamagable>();

        public static void InitializeDamagable(this IDamagable damagable)
        {
            DamageableList.Add(damagable.InstanceId, damagable);
        }
        public static void DestroyDamagable(this IDamagable damagable)
        {
            DamageableList.Remove(damagable.InstanceId);
        }
    }

    public interface IDamagable
    {
        int InstanceId { get; }
        void Damage(IDamage dmg);
    }
}