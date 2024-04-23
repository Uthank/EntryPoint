using System;
using Structure;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Input.Desktop
{
    public class DesktopInputService : IInputService
    {
        private readonly DesktopInputHandler _handler;
        
        public event Action<Vector2> AxisInputGotten;
        
        public DesktopInputService()
        {
            Debug.Log("DesktopInputService created");
            
            GameObject handlerPrefab = Services.ResourceLoaderService.LoadPrefab("DesktopInputHandler");
            //Debug.Log("handlerPrefab loaded " + handlerPrefab);
            _handler = Object.Instantiate(handlerPrefab).GetComponent<DesktopInputHandler>();
            //Debug.Log("handler instantiated " + _handler);
            _handler.AxisInputGotten += OnAxisInputGotten;
        }
        
        public void SetActive(bool value)
        {
            _handler.gameObject.SetActive(value);
        }

        private void OnAxisInputGotten(Vector2 axisInput)
        {
            AxisInputGotten?.Invoke(axisInput);
        }
    }
}