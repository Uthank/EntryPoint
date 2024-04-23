using System;
using UnityEngine;

namespace Input.Desktop
{
    public class DesktopInputHandler : MonoBehaviour
    {
        public event Action<Vector2> AxisInputGotten;

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }

        private void Update()
        {
            Vector2 axisInput = new Vector2(UnityEngine.Input.GetAxis("Vertical"), UnityEngine.Input.GetAxis("Horizontal"));

            if (axisInput.sqrMagnitude < .01f)
                return;

            axisInput = axisInput.normalized;
            AxisInputGotten?.Invoke(axisInput);
        }
    }
}