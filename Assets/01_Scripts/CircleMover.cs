using UnityEngine;

public class CircleMover : MonoBehaviour
{
    public float radius = 3f;
    public float speed = 1f;
    public Vector3 rotationAxis = Vector3.forward;

    private Vector3 localStartPosition;
    private float angle;

    void Start()
    {
        localStartPosition = transform.localPosition;
    }

    void Update()
    {
        angle += speed * 360f * Time.deltaTime;

        if (angle >= 360f)
            angle -= 360f;

        float rad = angle * Mathf.Deg2Rad;
        Vector3 offset = new Vector3(Mathf.Cos(rad), Mathf.Sin(rad), 0f) * radius;

        offset = Quaternion.LookRotation(rotationAxis) * offset;

        transform.localPosition = localStartPosition + offset;
    }
}