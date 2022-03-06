using UnityEngine;

namespace Pause
{
    public class NonControllableUnit : MonoBehaviour
    {
        [SerializeField] private float angularSpeed = 120;
        
        private void Update()
        {
            transform.Rotate(Vector3.right,Time.deltaTime * angularSpeed);
        }
    }
}