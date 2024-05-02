using UnityEngine;

namespace Game.UI
{
    public class MainMenu : Menu
    {
        [SerializeField] private Menu settingsMenu;
        [SerializeField] private Menu loadMenu;
        public void Play()
        {
            CloseMenu();
            loadMenu.OpenMenu();
        }

        public void OpenSettingsMenu()
        {
            CloseMenu();
            settingsMenu.OpenMenu();
        }
    }
}
