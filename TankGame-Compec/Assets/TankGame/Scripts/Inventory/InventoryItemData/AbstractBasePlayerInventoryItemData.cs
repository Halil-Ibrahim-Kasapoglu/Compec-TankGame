using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace TankGame.Inventory
{
    public abstract class AbstractBasePlayerInventoryItemData : ScriptableObject
    {

        protected PlayerInventoryController _inventoryController;

        protected CompositeDisposable _compositeDisposable;

        public virtual void Initialize(PlayerInventoryController targetPayerInventory)
        {

            _inventoryController = targetPayerInventory;
            _compositeDisposable = new CompositeDisposable();

        } 


        public virtual void Destroy()
        {
            _compositeDisposable.Dispose();
            Destroy(this);
        }
    }
}