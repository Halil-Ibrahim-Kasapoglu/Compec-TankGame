using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TankGame.Inventory;

namespace TankGame.Stat
{
    public class DamagableObjectBase : MonoBehaviour, IDamagable
    {

        [SerializeField] private Collider _collider;
        public int InstanceId { get; private set;}

        public void Damage(IDamage damage)
        {
            Debug.Log(damage + " damaged" );
        }

        private void Awake()
        {
            InstanceId = _collider.GetInstanceID();
            this.InitializeDamagable();
        }
    }
}