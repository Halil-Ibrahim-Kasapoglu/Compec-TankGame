using System.Collections;
using System.Collections.Generic;
using TankGame.UserInput;
using UnityEngine;


namespace TankGame.PlayerControls
{
    public class TowerRotationController : MonoBehaviour
    {
        [SerializeField] private AbstractInputData _rotationInput;
        [SerializeField] private TowerRotationSettings _towerRotationSettings;

        [SerializeField] private Transform _towerTransform;
        public Transform TowerTransform { get { return _towerTransform; } }

        public void InitializeInput(AbstractInputData inputData)
        {
            _rotationInput = inputData;
        }

        private void Update()
        {
            _towerTransform.Rotate(0, _rotationInput.Horizontal * _towerRotationSettings.TowerRotationSpeed, 0, Space.Self);
        }
    }
}