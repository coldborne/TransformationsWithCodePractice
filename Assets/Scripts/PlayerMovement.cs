using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _scalingSpeed;
    [SerializeField] private float _movementSpeed;

    void Update()
    {
        transform.Translate(Vector3.forward * _movementSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
        transform.localScale += Vector3.one * _scalingSpeed * Time.deltaTime;
    }
}
