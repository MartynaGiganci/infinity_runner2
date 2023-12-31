using UnityEngine;
public class ObjectRotator : MonoBehaviour
{
    public float rotationSpeed = 2f;

    public void Start()
    {
        rotationSpeed = Random.Range(0.5f * rotationSpeed, 1.5f * rotationSpeed);
    }

    public void FixedUpdate()
    {
        transform.Rotate(new Vector3(0f, 0f, rotationSpeed));
    }
}