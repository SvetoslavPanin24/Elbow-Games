using Game.Managers;

namespace Game.Items
{
    public class Bomb : Item
    {
        public override void Use()
        {
            EventBus.OnBombPickedUp?.Invoke();
            Destroy(gameObject);
        }
    }
}