using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame.AI
{
    [CreateAssetMenu(menuName = "Tank Game/AI/AI Input Rotation Data")]
    public class InputRotationDataAI : InputDataAI
    {

        public override void ProcessInput()
        {
            base.ProcessInput();
            Vector3 direction = _currentTarget - _targetTransform.position;

            if (Mathf.Abs(direction.y - _targetTransform.rotation.eulerAngles.y) > 0.25f)
            {
                Horizontal = 1;

            }else
            {
                Horizontal = 0;
            }
        }

    }
}