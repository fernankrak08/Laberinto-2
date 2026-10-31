using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject respawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Update()
    {

        if (transform.position.y < -1)
        {
            transform.position = respawn.transform.position;
            print("Vuelve a empezar");
        }

        if(Input.GetKey(KeyCode.R))
        {
            transform.position = respawn.transform.position;
            print("Vuelve a empezar");
        }
    }
}
