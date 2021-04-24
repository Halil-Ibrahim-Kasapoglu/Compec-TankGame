using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TankGame.Stat;

namespace TankGame.Inventory
{

    public class PlayerInventoryCannonItemMono : AbstractPlayerInventoryItemMono
    {

        [SerializeField] private Transform _launchPoint;

        public void Shoot(IDamage damage, PlayerStat stat)
        {
            ScriptableShootManager.Instance.Shoot(_launchPoint.position, _launchPoint.forward , damage , stat);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawRay(_launchPoint.position, _launchPoint.forward);           
        }
    }
}