using System;
using UnityEngine;

namespace Pause.Components
{
    public class HasPause : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        private bool _isPhysical = false;
        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            if (_rigidbody != null)
            {
                _isPhysical = true;
            }
        }

        public void Pause(bool isPaused)
        {
            var components = GetComponents<MonoBehaviour>();
            foreach (var behaviour in components)
            {
                behaviour.enabled = !isPaused;
            }

            if (!_isPhysical) return;

            if (isPaused)
            {
                _rigidbody.Sleep();
            }
            else
            {
                _rigidbody.WakeUp();
            }
        }
    }
}