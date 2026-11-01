using UnityEngine;

public class Rotacion : MonoBehaviour
{
    [SerializeField]
    float rotacionY = 20f;

    void Update()
    {
        transform.Rotate(0f, rotacionY * Time.deltaTime, 0f);
    }

    private void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.CompareTag("Player"))
        {
            colision.transform.position = new Vector3(colision.transform.position.x, -2f ,colision.transform.position.z);
        }
    }
}