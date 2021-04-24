using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TankGame.Inventory;
using TankGame.UserInput;

namespace TankGame
{
    public class LocalPlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerInventoryController _playerInventoryController;
        [SerializeField] private PlayerInputData _shootInput;

        private void Update()
        {
            if (_shootInput.Horizontal > 0) {
                _playerInventoryController.ReactiveShootCommand.Execute();
            }

        }
    }
}