using UnityEngine.Audio;
using UnityEngine;

namespace Game.Managers
{
    public class MusicManager : MonoBehaviour
    {
        [SerializeField] private AudioMixerGroup mixer;
        private static MusicManager instance;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(this);
            }
            else if (instance != this)
            {
                Destroy(gameObject);
            }
        }
        private void Start()
        {
            mixer.audioMixer.SetFloat("MusicVolume", PlayerPrefs.GetInt("MusicVolumeEnabled") == 1 ? 0 : -80);
        }
    }
}