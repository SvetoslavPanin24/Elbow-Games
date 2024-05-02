using UnityEngine;

namespace Game.UI
{
    public class GameOverMenu : Menu
    {
        [SerializeField] private Menu LoadMenu;

        public void Retry()
        {
            CloseMenu();
            LoadMenu.OpenMenu();
        }

        public void LoadMainMenu()
        {
            CloseMenu();
            LoadMenu.OpenMenu();
        }
    }
}

