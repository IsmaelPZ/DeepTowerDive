using UnityEngine;

public class MoveLevel : MonoBehaviour
{
    public float scrollSpeed = 2f; // Geschwindigkeit nach oben

    void Update()
    {
        transform.Translate(Vector3.up * scrollSpeed * Time.deltaTime);
    }
}
