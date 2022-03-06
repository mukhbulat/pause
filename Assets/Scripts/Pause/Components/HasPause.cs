using UnityEngine;

namespace Pause.Components
{
    public class HasPause : MonoBehaviour
    {
        public void Pause(bool isPaused)
        {
            var components = GetComponents<MonoBehaviour>();
            foreach (var behaviour in components)
            {
                behaviour.enabled = !isPaused;
            }
        }
    }
}