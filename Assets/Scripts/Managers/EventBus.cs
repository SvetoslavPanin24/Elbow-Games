using System;

namespace Game.Managers
{
    public static class EventBus
    {
        public static Action OnCoinPickedUp;
        public static Action OnBombPickedUp;
        public static Action OnGameEnd;
    }
}
