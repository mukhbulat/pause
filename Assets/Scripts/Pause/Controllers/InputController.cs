using System;
using Pause.Components;
using UnityEngine;

namespace Pause.Controllers
{
    
    [RequireComponent(typeof(HasPause))]
    public class InputController : MonoBehaviour
    {
        public Action Fire1Pressed;
        public Action JumpPressed;

        public bool IsInputAvailable { get; private set; } = true;

        void Update()
        {
            if (!IsInputAvailable) return;
            if (Input.GetButton("Fire1"))
            {
                Fire1Pressed?.Invoke();
            }

            if (Input.GetButtonDown("Jump"))
            {
                JumpPressed?.Invoke();
            }
        }
    }
}
