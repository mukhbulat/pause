using Pause.Components;
using UnityEngine;

namespace Pause.Controllers
{
    public class PauseController : MonoBehaviour
    {
        private HasPause[] _pausableComponents;
        private bool _isPaused;

        private void Start()
        {
            // Number of GameObjects on scene is constant. For variable size - use List or may be dict and
            // check before each pause.
            _pausableComponents = FindObjectsOfType<HasPause>();
        }

        public void Pause()
        {
            _isPaused = !_isPaused;
            foreach (var pausable in _pausableComponents)
            {
                pausable.Pause(_isPaused);
            }
        }
    }
}