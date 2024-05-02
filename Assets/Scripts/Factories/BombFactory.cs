using UnityEngine;

namespace Game.Items
{
    public class BombFactory : ItemFactory<Bomb>
    {
        public override Bomb CreateItem()
        {
            float randomXPosition = Random.Range(-screenBoundsX + itemWidth, screenBoundsX - itemWidth);
            return Instantiate(itemPrefab, new Vector3(randomXPosition, spawnYPosition, 0), Quaternion.identity);
        }
    }
}