using Structure;
using UnityEngine;

namespace Game
{
    public class HeroMover : MonoBehaviour
    {
        [SerializeField] private float _speed = 3;

        private void Awake()
        {
            Services.InputService.AxisInputGotten += OnAxisInputGotten;
        }

        private void OnDestroy()
        {
            Services.InputService.AxisInputGotten -= OnAxisInputGotten;
        }

        private void OnAxisInputGotten(Vector2 axisInput)
        {
            transform.position += new Vector3(-axisInput.x, 0 , axisInput.y) * Time.deltaTime * _speed;
        }
    }
}