using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TankGame.UserInput;

namespace TankGame.PlayerControls
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private AbstractInputData _inputData;
        [SerializeField] private Transform _targetTransform;
        [SerializeField] private PlayerMovementSettings _playerMovementSettings;

        public void InitializeInput(AbstractInputData inputData)
        {
            _inputData = inputData;
        }

        private void Update()
        {
            _rigidbody.MovePosition(_rigidbody.position + (_rigidbody.transform.forward * _inputData.Vertical * _playerMovementSettings.VerticalSpeed * Time.deltaTime));
            _targetTransform.Rotate(0, _inputData.Horizontal * _playerMovementSettings.HorizontalSpeed * Time.deltaTime, 0, Space.Self);
        }
    }
}