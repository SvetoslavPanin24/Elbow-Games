using UnityEngine;

namespace Game.UI
{
    public class PauseMenu : Menu
    {
        [SerializeField] private GameObject pauseButton;
        public void PauseGame()
        {
            OpenMenu();
            pauseButton.SetActive(false);
            Time.timeScale = 0f;
        }

        // Вызывается для возобновления игры
        public void ResumeGame()
        {
            CloseMenu();
            pauseButton.SetActive(true);
            Time.timeScale = 1f;
        }
    }
}
