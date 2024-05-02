using UnityEngine;
using UnityEngine.EventSystems; // Добавляем пространство имен для работы с системой событий

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private BoxCollider2D playerCollider;
    private float screenBounds;
    private float playerWidth;
    private Vector2 colliderOffset;

    private void Start()
    {        
        playerWidth = playerCollider.bounds.size.x / 2;
        colliderOffset = playerCollider.offset;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z)).x - playerWidth;
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Проверяем, не находится ли касание над элементом UI
            if (!EventSystem.current.IsPointerOverGameObject(touch.fingerId))
            {
                if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
                {
                    if (touch.position.x < Screen.width / 2)
                    {
                        // Движение влево
                        Move(-1);
                    }
                    else if (touch.position.x > Screen.width / 2)
                    {
                        // Движение вправо
                        Move(1);
                    }
                }
            }
        }
    }

    private void Move(int direction)
    {
        float newXPosition = Mathf.Clamp(transform.position.x + direction * speed * Time.deltaTime, -screenBounds + colliderOffset.x, screenBounds - colliderOffset.x);
        transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);

        if (direction < 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0)); // Персонаж идет влево
        }
        else if (direction > 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0)); // Персонаж идет вправо
        }
    }
}