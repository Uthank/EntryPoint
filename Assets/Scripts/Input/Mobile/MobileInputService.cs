using System;
using UnityEngine;

namespace Input.Mobile
{
    public class MobileInputService : IInputService
    {
        public event Action<Vector2> AxisInputGotten;
        
        
        public void SetActive(bool value)
        {
        }
    }
}