using UnityEngine;

public class RotationMover : MonoBehaviour
{
    [SerializeField] public float rotationAngle = 45f;   
    [SerializeField] public float speed = 50f;           

    private Quaternion startRotation;
    private Quaternion targetRotation;
    private bool rotatingForward = true;

    void Start()
    {
        startRotation = transform.localRotation;
        targetRotation = startRotation * Quaternion.Euler(0f, 0f, rotationAngle);
    }

    void Update()
    {
        Quaternion target = rotatingForward ? targetRotation : startRotation;
        transform.localRotation = Quaternion.RotateTowards(transform.localRotation, target, speed * Time.deltaTime);

        if (Quaternion.Angle(transform.localRotation, target) < 0.1f)
            rotatingForward = !rotatingForward;
    }
}
