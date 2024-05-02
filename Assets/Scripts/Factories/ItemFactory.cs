using UnityEngine;

namespace Game.Items
{
    public abstract class ItemFactory<T> : MonoBehaviour where T : MonoBehaviour
    {
        [SerializeField] protected T itemPrefab;
        [SerializeField] protected Transform positiomToSpawn;

        public float spawnYPosition = 10f; // Фиксированная позиция Y для спавна
        protected float screenBoundsX;
        protected float itemWidth;

        protected void Start()
        {
            screenBoundsX = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z)).x;
            itemWidth = itemPrefab.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        }

        public abstract T CreateItem();
    }
}