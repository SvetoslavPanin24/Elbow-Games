using UnityEngine;

namespace Game.UI
{
    public class ButtonFX : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;
        [SerializeField] private AudioClip clickSound;

        public void PlayerClickSound()
        {
            audioSource.PlayOneShot(clickSound);
        }
    }
}
