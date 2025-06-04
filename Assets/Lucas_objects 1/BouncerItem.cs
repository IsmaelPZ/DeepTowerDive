using UnityEngine;

public class ImpulseSphere : MonoBehaviour
{
    public float impulseStrength = 10f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 impulse = transform.up * impulseStrength;
                rb.AddForce(impulse, ForceMode.Impulse);
            }
        }
    }
}
