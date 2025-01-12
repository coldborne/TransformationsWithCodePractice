using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        transform.Rotate(Quaternion.Euler(0, 90f, 0) * Vector3.up * _rotationSpeed * Time.deltaTime);
    }
}
