using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Game.UI
{
    public class SettingsMenu : Menu
    {
        [SerializeField] private Menu mainMenu;

        [SerializeField] private AudioMixerGroup mixer;
        [SerializeField] private Toggle musicVolumeToggle;
        [SerializeField] private Toggle gameVolumeToggle;

        private void Start()
        {
            musicVolumeToggle.isOn = PlayerPrefs.GetInt("MusicVolumeEnabled") == 1;
            gameVolumeToggle.isOn = PlayerPrefs.GetInt("GameVolumeEnabled") == 1;
        }

        public void ToggleMusicVolume(bool enabled)
        {
            if (enabled)
            {
                mixer.audioMixer.SetFloat("MusicVolume", 0);
            }
            else
            {
                mixer.audioMixer.SetFloat("MusicVolume", -80);
            }

            PlayerPrefs.SetInt("MusicVolumeEnabled", enabled ? 1 : 0);
        }

        public void ToggleGameVolume(bool enabled)
        {
            if (enabled)
            {
                mixer.audioMixer.SetFloat("GameVolume", 0);
            }
            else
            {
                mixer.audioMixer.SetFloat("GameVolume", -80);
            }

            PlayerPrefs.SetInt("GameVolumeEnabled", enabled ? 1 : 0);
        }

        public void CloseSettingMenu()
        {
            CloseMenu();
            mainMenu.OpenMenu();
        }
    }
}
