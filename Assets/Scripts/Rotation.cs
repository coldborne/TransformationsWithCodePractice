using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _yRotationAngle;

    private void Update()
    {
        Vector3 rotation = Quaternion.Euler(0, _yRotationAngle, 0) * Vector3.up * (_rotationSpeed * Time.deltaTime);
        transform.Rotate(rotation, Space.Self);
    }
}
