using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private float _scalingSpeed;

    private void Update()
    {
        transform.localScale += Vector3.one * (_scalingSpeed * Time.deltaTime);
    }
}
