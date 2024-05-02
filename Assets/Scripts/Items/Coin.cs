using Game.Managers;

public class Coin : Item
{
    public override void Use()
    {
        EventBus.OnCoinPickedUp?.Invoke();
        Destroy(gameObject);
    }
}