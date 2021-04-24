using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TankGame.UserInput;

namespace TankGame.AI {
    public class InputDataAI : AbstractInputData
    {
        protected Vector3 _currentTarget;
        protected Transform _targetTransform;

        public void SelectTarget(Transform targetTransform, Vector3 target)
        {
            _targetTransform = targetTransform;
            _currentTarget = target;

        }

        public override void ProcessInput()
        {
        }

    }
}