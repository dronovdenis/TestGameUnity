using UnityEngine;

public class MoveBird : MonoBehaviour {

    public Transform bird;

    private void OnMouseDrag() {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        bird.position = new Vector2(mousePos.x, bird.position.y);
        
    }


}
