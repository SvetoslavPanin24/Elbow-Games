using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public abstract void Use();

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}