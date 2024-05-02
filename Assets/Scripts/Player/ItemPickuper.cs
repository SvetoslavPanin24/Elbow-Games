using UnityEngine;

public class ItemPickuper : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Item item = other.GetComponent<Item>();
        if (item != null)
        {
            item.Use();            
        }
    }
}
