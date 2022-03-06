using Pause.Controllers;
using UnityEngine;

namespace Pause
{
    [RequireComponent(typeof(InputController))]
    public class ControllableUnit : MonoBehaviour
    {
        [SerializeField] private InputController inputController;
        [SerializeField] private float angularSpeed = 120;
        private bool _onUpperFloor = false;
        
        
        private void OnEnable()
        {
            inputController.Fire1Pressed += OnFire1Pressed;
            inputController.JumpPressed += OnJumpPressed;
        }

        private void OnDisable()
        {
            inputController.Fire1Pressed -= OnFire1Pressed;
            inputController.JumpPressed -= OnJumpPressed;
        }
        
        private void OnJumpPressed()
        {
            var transformPosition = transform.position;
            float x = transformPosition.x;
            float y = transformPosition.y;
            float z = transformPosition.z;
            transform.position = _onUpperFloor ? new Vector3(x, y + 1, z) : new Vector3(x, y - 1, z);
            _onUpperFloor = !_onUpperFloor;
        }

        private void OnFire1Pressed()
        {
            transform.Rotate(Vector3.up, Time.deltaTime * angularSpeed);
        }
    }
}