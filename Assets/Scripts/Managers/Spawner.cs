using Game.Items;
using UnityEngine;

namespace Game.Managers
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private CoinFactory coinFactory;
        [SerializeField] private BombFactory bombFactory;
        [SerializeField] private float spawnFrequency = 1;

        private void Start()
        {
            InvokeRepeating("SpawnItem", 0, spawnFrequency);
        }

        public void SpawnItem()
        {
            Item item = Random.Range(0, 5) == 0 ? bombFactory.CreateItem() : coinFactory.CreateItem();
            item.transform.SetParent(transform);
        }
    }
}