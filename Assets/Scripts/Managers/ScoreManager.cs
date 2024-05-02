using TMPro;
using UnityEngine;

namespace Game.Managers
{
    public class ScoreManager : MonoBehaviour
    {
        private int score = 0;
        [SerializeField] private TMP_Text scoreText;
        [SerializeField] private TMP_Text totalScoreText;

        private void OnEnable()
        {
            EventBus.OnCoinPickedUp += AddScore;
            EventBus.OnGameEnd += SetUpTotalScoreText;
        }

        private void OnDisable()
        {
            EventBus.OnCoinPickedUp -= AddScore;
            EventBus.OnGameEnd -= SetUpTotalScoreText;
        }

        private void AddScore()
        {
            score += 1;
            // Обновление UI счета

            scoreText.text = score.ToString();
        }

        private void SetUpTotalScoreText()
        {
            totalScoreText.text = score.ToString();
        }
    }
}