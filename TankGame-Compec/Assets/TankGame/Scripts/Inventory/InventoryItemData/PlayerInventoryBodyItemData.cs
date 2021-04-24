using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame.Inventory
{
    [CreateAssetMenu(menuName = "Tank Game/Inventory/Player Inventory Body Item Data")]
    public class PlayerInventoryBodyItemData : AbstractPlayerInventoryItemData<PlayerInventoryBodyItemMono>
    {
        public override void Initialize(PlayerInventoryController targetPayerInventory)
        {
            var instantiated = InstantiateAndInitializePrefab(targetPayerInventory.BodyParent);
        }
    }
}