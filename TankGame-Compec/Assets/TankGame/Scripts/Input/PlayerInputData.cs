using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TankGame.UserInput
{
    [CreateAssetMenu(menuName = "Tank Game/Input/Player Input Data")]
    public class PlayerInputData : AbstractInputData
    {
        [Header("Axis Base Control")]
        [SerializeField] private bool _axisActive;
        [SerializeField] private string AxisNameHorizontal;
        [SerializeField] private string AxisNameVertical;

        [Header("Key Base Control")]
        [SerializeField] private bool _keyBaseHorizontalActive;
        [SerializeField] private KeyCode PositiveHorizontalKeyCode;
        [SerializeField] private KeyCode NegativeHorizontalKeyCode;
        [SerializeField] private bool _keyBaseVerticalActive;
        [SerializeField] private KeyCode PositiveVerticalKeyCode;
        [SerializeField] private KeyCode NegativeVerticalKeyCode;

        [SerializeField] private float _lerpSpeed;

        public override void ProcessInput()
        {
            if (_axisActive)
            {
                Horizontal = Input.GetAxis(AxisNameHorizontal);
                Vertical = Input.GetAxis(AxisNameVertical);
            }
            else
            {
                if (_keyBaseHorizontalActive)
                {
                    KeyBaseAxisControl(ref Horizontal, PositiveHorizontalKeyCode, NegativeHorizontalKeyCode);
                }
                if (_keyBaseVerticalActive)
                {
                    KeyBaseAxisControl(ref Vertical, PositiveVerticalKeyCode, NegativeVerticalKeyCode);
                }
            }
        }

        private void KeyBaseAxisControl(ref float value, KeyCode positive, KeyCode negative)
        {
            bool positiveActive = Input.GetKey(positive);
            bool negativeActive = Input.GetKey(negative);
            if (positiveActive)
            {
                value = Mathf.Lerp(value, 1, Time.deltaTime * _lerpSpeed);
            }
            else if (negativeActive)
            {
                value = Mathf.Lerp(value, -1, Time.deltaTime * _lerpSpeed);
            }
            else
            {
                value = Mathf.Lerp(value, 0, Time.deltaTime * _lerpSpeed);
            }
        }


    }
}