using UnityEngine;

public class HorizontalMover : MonoBehaviour
{
    [SerializeField] public float moveDistance = 5f;
    [SerializeField] public float speed = 2f;

    private Vector3 localStartPosition;
    private bool movingForward = true;

    void Start()
    {
        localStartPosition = transform.localPosition;
    }

    void Update()
    {
        Vector3 target = localStartPosition + Vector3.right * (movingForward ? moveDistance : 0f);
        
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, target, speed * Time.deltaTime);
        
        if (Vector3.Distance(transform.localPosition, target) < 0.01f)
            movingForward = !movingForward;
    }
}