using Game.UI;
using UnityEngine;

namespace Game.Managers
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private Menu gameOverMenu;
        [SerializeField] private GameObject player;
        [SerializeField] private GameObject itemSpawner;

        [SerializeField] private GameObject explosion;

        private void OnEnable()
        {
            EventBus.OnBombPickedUp += GameOver;
        }

        private void OnDisable()
        {
            EventBus.OnBombPickedUp -= GameOver;
        }

        private void GameOver()
        {
            explosion = Instantiate(explosion, player.transform);
            explosion.transform.localPosition = new Vector3(-0.5f, -0.6f, 0);
            player.GetComponent<PlayerMovement>().enabled = false;
            Destroy(itemSpawner);
            Invoke(nameof(End), explosion.GetComponent<Animation>().GetClip("ExplosionAppearance").length);
        }

        private void End()
        {
            gameOverMenu.OpenMenu();
            EventBus.OnGameEnd.Invoke();
            Destroy(player);
        }
    }
}