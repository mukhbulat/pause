using System;
using UnityEngine;

namespace Pause.Controllers
{
    public class InputController : MonoBehaviour
    {
        public Action Fire1Pressed;
        public Action JumpPressed;

        void Update()
        {
            if (Input.GetButton("Fire1"))
            {
                Fire1Pressed?.Invoke();
            }

            if (Input.GetButtonDown("Jump"))
            {
                JumpPressed?.Invoke();
            }
        }

        public void Pause(bool isPaused)
        {
            enabled = !isPaused;
        }
    }
}
