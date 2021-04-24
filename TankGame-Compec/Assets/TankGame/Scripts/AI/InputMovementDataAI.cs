using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame.AI
{
    [CreateAssetMenu(menuName = "Tank Game/AI/AI Input Movement Data")]
    public class InputMovementDataAI : InputDataAI
    {

        public override void ProcessInput()
        {
            float distance = Vector3.Distance(_targetTransform.position, _currentTarget);
            if (distance > 0)
            {
                Horizontal = 1;
            }else
            {
                Horizontal = 0;
            }

            base.ProcessInput();
        }
    }
}