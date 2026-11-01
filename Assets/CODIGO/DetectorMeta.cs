using UnityEngine;
using TMPro;

public class DetectorMeta : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaFinal;
    [SerializeField]
    TextMeshProUGUI textLabelTime;
    float tiempoDePartida = 0f;
    bool estaJugando = true;

    private void Start()
    {
        pantallaFinal.SetActive(false);
    }

    private void Update()
    {
        if(estaJugando == true)
        {
            tiempoDePartida += Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "Player")
        {

            pantallaFinal.SetActive(true);
            other.GetComponent<movimiento>().enabled = false;
            other.GetComponent<Respawn>().enabled = false;
            estaJugando = false;
            textLabelTime.text = tiempoDePartida.ToString();
        }
    }
}
