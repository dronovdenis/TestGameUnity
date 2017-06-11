using UnityEngine;

public class MoveBird : MonoBehaviour
{

    public Transform bird;
    [SerializeField]
    private float speed = 10f;

    private void OnMouseDrag()
    {
        if (!Bird.lose)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x > 2.5f ? 2.5f : mousePos.x;
            mousePos.x = mousePos.x < -2.5f ? -2.5f : mousePos.x;
            bird.position = Vector2.MoveTowards(bird.position,
                new Vector2(mousePos.x, bird.position.y),
                speed * Time.deltaTime);
        }
        
    }

}
