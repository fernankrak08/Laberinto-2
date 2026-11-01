
using UnityEngine;

public class RestaurarParedesinicio : MonoBehaviour
{
    [SerializeField]
    GameObject todosLosObstaculos;

    [SerializeField]
    GameObject obstaculosRotativos;

    [SerializeField]
    GameObject murosLimite;

    [SerializeField]
    Material colorReinicio;

    [SerializeField]
    Material colorReinicioRotativos;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            for (int i = 0; i < todosLosObstaculos.transform.childCount; i++)
            {
                todosLosObstaculos.transform.GetChild(i).GetComponent<MeshRenderer>().material = colorReinicio;
            }

            for (int i = 0; i < obstaculosRotativos.transform.childCount; i++)
            {
                obstaculosRotativos.transform.GetChild(i).GetComponent<MeshRenderer>().material = colorReinicioRotativos;
            }

            for (int i = 0; i < murosLimite.transform.childCount; i++)
            {
                murosLimite.transform.GetChild(i).GetComponent<MeshRenderer>().material = colorReinicio;
            }
        }
    }
}

