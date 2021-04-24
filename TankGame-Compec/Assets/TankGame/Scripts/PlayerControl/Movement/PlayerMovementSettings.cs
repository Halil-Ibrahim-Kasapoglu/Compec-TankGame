using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame.PlayerControls
{
    [CreateAssetMenu(menuName = "Tank Game/Player Controls/Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        public float VerticalSpeed = 5;

        public float HorizontalSpeed = 5;
        
    }
}