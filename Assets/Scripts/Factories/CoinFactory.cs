using UnityEngine;

namespace Game.Items
{
    public class CoinFactory : ItemFactory<Coin>
    {
        public override Coin CreateItem()
        {
            float randomXPosition = Random.Range(-screenBoundsX + itemWidth, screenBoundsX - itemWidth);
            return Instantiate(itemPrefab, new Vector3(randomXPosition, spawnYPosition, 0), Quaternion.identity);
        }
    }
} 