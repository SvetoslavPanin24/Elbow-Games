using UnityEngine;
using UnityEngine.Audio;

namespace Game.Managers
{
    public class GameSoundManager : MonoBehaviour
    {
        [SerializeField] private AudioMixerGroup mixer;
        [SerializeField] private AudioSource audioSource;
        [SerializeField] private AudioClip coinSound;
        [SerializeField] private AudioClip bombSound;
        private void OnEnable()
        {
            EventBus.OnCoinPickedUp += PlayCoinSound;
            EventBus.OnBombPickedUp += PlayBombSound;
        }

        private void OnDisable()
        {
            EventBus.OnCoinPickedUp -= PlayCoinSound;
            EventBus.OnBombPickedUp -= PlayBombSound;
        }

        private void Start()
        {
            mixer.audioMixer.SetFloat("MusicVolume", PlayerPrefs.GetInt("MusicVolumeEnabled") == 1 ? 0 : -80);
        }

        private void PlayCoinSound()
        {
            audioSource.PlayOneShot(coinSound);
        }

        private void PlayBombSound()
        {
            audioSource.PlayOneShot(bombSound);
        }
    }
}
