using UnityEngine;

public class DetectorMeta : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaFinal;

    private void Start()
    {
        pantallaFinal.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "Player")
        {
            print("jugador llego a la meta");
            pantallaFinal.SetActive(true);
            other.GetComponent<movimiento>().enabled = false;
        }
    }
}
