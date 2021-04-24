using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame.UserInput
{
    public abstract class AbstractInputData : ScriptableObject
    {
        public float Vertical;
        public float Horizontal;
        public abstract void ProcessInput();
    }
}