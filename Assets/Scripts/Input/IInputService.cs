using System;
using UnityEngine;

namespace Input
{
    public interface IInputService
    {
        public event Action<Vector2> AxisInputGotten;
    
        public void SetActive(bool value);
    }
}