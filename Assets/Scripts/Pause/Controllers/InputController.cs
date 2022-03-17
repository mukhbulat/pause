using System;
using Pause.Components;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Pause.Controllers
{
    [RequireComponent(typeof(HasPause))]
    public class InputController : MonoBehaviour
    {
        public Action Fire1Pressed;
        public Action JumpPressed;

        public bool IsInputAvailable { get; private set; } = true;

        private EventSystem _currentEventSystem;

        private void Awake()
        {
            _currentEventSystem = EventSystem.current;
        }
        
        private void Update()
        {
            if (!IsInputAvailable) return;
            if (Input.GetButton("Fire1"))
            {
                if (_currentEventSystem.IsPointerOverGameObject()) return;
                Fire1Pressed?.Invoke();
            }

            if (Input.GetButtonDown("Jump"))
            {
                JumpPressed?.Invoke();
            }
        }
    }
}
