using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TankGame.Stat;
using UniRx;

namespace TankGame.Inventory
{
    [CreateAssetMenu(menuName = "Tank Game/Inventory/Scriptable Shoot Manager")]
    public class ScriptableShootManager : AbstractScriptableManager<ScriptableShootManager>
    {
        public override void Initialize()
        {
            Debug.Log("Scriptable Shoot Manager Initalized");
            base.Initialize();
        }

        public override void Destroy()
        {
            base.Destroy();
        }

        public void Shoot(Vector3 origin, Vector3 direction, IDamage damage, PlayerStat stat)
        {
            RaycastHit rHit;
            var physic = Physics.Raycast(origin, direction, out rHit);
            MessageBroker.Default.Publish(new EventPlayerShoot(origin, stat));
            if (physic)
            {
                Debug.Log("Shoot : " + rHit.collider.name); ;
                int colliderInstanceId = rHit.collider.GetInstanceID();
                if (DamageableHelper.DamageableList.ContainsKey(colliderInstanceId))
                {
                    DamageableHelper.DamageableList[colliderInstanceId].Damage(damage);
                }
            }
        }

    }
}