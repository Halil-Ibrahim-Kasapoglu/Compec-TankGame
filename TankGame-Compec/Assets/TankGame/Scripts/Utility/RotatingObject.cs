using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame.Utility {
    public class RotatingObject : MonoBehaviour
    {
        [SerializeField] private Vector3 _rotateSpeed;

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(_rotateSpeed.x * Time.deltaTime, _rotateSpeed.y * Time.deltaTime, _rotateSpeed.z * Time.deltaTime , Space.Self);
        }
    }
}