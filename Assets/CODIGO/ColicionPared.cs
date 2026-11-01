using UnityEngine;

public class ColicionPared : MonoBehaviour
{
    [SerializeField]
    Material materialPorDefecto;

    [SerializeField]
    Material materialParedTocada;

    bool paredRoja = false;

    float tiempoEnRojo = 3f;

    private void Update()
    {
        if (paredRoja == true)
        {
            tiempoEnRojo = tiempoEnRojo - Time.deltaTime;

            if (tiempoEnRojo < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = materialPorDefecto;
                paredRoja = false;
                tiempoEnRojo = 3f;
            }
        }
    }

   
    private void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material = materialParedTocada;
            paredRoja = true;
        }
    }
}