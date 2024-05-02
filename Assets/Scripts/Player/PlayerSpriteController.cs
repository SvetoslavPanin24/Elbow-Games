using Game.Managers;
using UnityEngine;

public class PlayerSpriteController : MonoBehaviour
{
    [SerializeField] private Sprite characterWithCoins;

    private void OnEnable()
    {
        EventBus.OnCoinPickedUp += ChangePlayerSprite;
    }

    private void OnDisable()
    {
        EventBus.OnCoinPickedUp -= ChangePlayerSprite;
    }

    private void ChangePlayerSprite()
    {
        GetComponent<SpriteRenderer>().sprite = characterWithCoins;
        EventBus.OnCoinPickedUp -= ChangePlayerSprite;
    }
}
