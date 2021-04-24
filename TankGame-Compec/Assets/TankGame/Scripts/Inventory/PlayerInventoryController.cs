using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using TankGame.Stat;

namespace TankGame.Inventory
{
    public class PlayerInventoryController : MonoBehaviour
    {
        [SerializeField] private AbstractBasePlayerInventoryItemData[] _inventoryItemDataArray;
        private List<AbstractBasePlayerInventoryItemData> _instantiatedItemDataList;
        public Transform BodyParent;
        public Transform CannonParent;

        public ReactiveCommand ReactiveShootCommand { get; private set; }
        public PlayerStat PlayerStat { get; private set; }

        private void Start()
        {

            InitializeInventory(_inventoryItemDataArray);
        }

        private void OnDestroy()
        {

            ClearInventory();
        }


        public void InitializeInventory(AbstractBasePlayerInventoryItemData[] inventoryItemDataArray)
        {
            if (ReactiveShootCommand != null)
            {
                ReactiveShootCommand.Dispose();
            }
            ReactiveShootCommand = new ReactiveCommand();


            ClearInventory();
            _instantiatedItemDataList = new List<AbstractBasePlayerInventoryItemData>(inventoryItemDataArray.Length);


            foreach (var item in _inventoryItemDataArray)
            {
                var instantiated = Instantiate(item);
                instantiated.Initialize(this);
                _instantiatedItemDataList.Add(instantiated);
            }
        }

        private void ClearInventory()
        {
            if (_instantiatedItemDataList != null)
            {
                foreach (var item in _instantiatedItemDataList)
                {
                    item.Destroy();
                }
            }
        }
        public void SetStat(PlayerStat stat)
        {
            PlayerStat = stat;
        }
        private void Update()
        {
            
        }

    }
}
