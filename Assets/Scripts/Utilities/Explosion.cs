using UnityEngine;

namespace Game.Utilities
{
    public class Explosion : MonoBehaviour
    {
        private void Start()
        {
            Destroy(gameObject, 1);
        }
    }
}
