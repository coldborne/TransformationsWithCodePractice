using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    
    private void Update()
    {
        Vector3 shift = Vector3.forward * (_movementSpeed * Time.deltaTime);
        transform.Translate(shift);
    }
}
