
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float velocidad = 0.01f;
    public float salto = 0.05f;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * velocidad;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * velocidad;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * velocidad;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * velocidad;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * velocidad;
        }
    }
}
