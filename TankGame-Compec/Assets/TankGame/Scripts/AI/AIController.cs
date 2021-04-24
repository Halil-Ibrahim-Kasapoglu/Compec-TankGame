using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TankGame.UserInput;
using TankGame.PlayerControls;
using TankGame.Inventory;

namespace TankGame.AI
{
    public class AIController : MonoBehaviour
    {

        [SerializeField] private InputDataAI _aiMovementInput;
        [SerializeField] private InputDataAI _aiRotationInput;
        [SerializeField] private PlayerMovementController _playerMovementController;
        [SerializeField] private TowerRotationController _towerRotationController;
        [SerializeField] private PlayerInventoryController _inventoryController;

        public Transform target;

        private void Awake()
        {
            _aiMovementInput = Instantiate(_aiMovementInput);
            _aiRotationInput = Instantiate(_aiRotationInput);
            _playerMovementController.InitializeInput(_aiMovementInput);
            _towerRotationController.InitializeInput(_aiRotationInput);

            _aiMovementInput.SelectTarget(target, target.position);
            _aiRotationInput.SelectTarget(target, target.position);


        }

        private void Update()
        {
            _aiMovementInput.ProcessInput();
            _aiRotationInput.ProcessInput();
        }

    }
}