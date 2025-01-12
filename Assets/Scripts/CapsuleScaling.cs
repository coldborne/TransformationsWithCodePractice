using UnityEngine;

public class CapsuleScaling : MonoBehaviour
{
    [SerializeField] private float _scalingSpeed;

    void Update()
    {
        transform.localScale += Vector3.one * _scalingSpeed * Time.deltaTime;
    }
}
