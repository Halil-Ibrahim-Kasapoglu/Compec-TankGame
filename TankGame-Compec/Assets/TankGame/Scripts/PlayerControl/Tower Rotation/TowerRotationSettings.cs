using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame.PlayerControls
{
    [CreateAssetMenu(menuName = "Tank Game/Player Controls/Tower Rotation Settings")]
    public class TowerRotationSettings : ScriptableObject
    {
        public float TowerRotationSpeed = 1;
    }
}