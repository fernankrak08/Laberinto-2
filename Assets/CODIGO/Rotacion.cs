using UnityEngine;

public class Rotacion : MonoBehaviour
{
    [SerializeField]
    float rotacionY = 20f;
    
    void Update()
    {
        transform.Rotate(0f, rotacionY * Time.deltaTime, 0f);
    }
}
