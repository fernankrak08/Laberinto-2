using UnityEngine;

public class cuboDeEmpuje : MonoBehaviour
{
    [SerializeField]
    float velocidad = 5f;

    void Update()
    {
        transform.Translate(0f, 0f, velocidad * Time.deltaTime);

        if (transform.position.z >= 11f )
        {
            transform.position =new Vector3(transform.position.x, transform.position.y ,- 1.43f);
        }
        
    }
    private void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.CompareTag("Player"))
        {
            colision.transform.position = new Vector3(colision.transform.position.x, -2f, colision.transform.position.z);
        }
    }
}
