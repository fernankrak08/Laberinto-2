
using TMPro;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject respawn;

    [SerializeField]
    GameObject pantallaDerrota;

    [SerializeField]
    TextMeshProUGUI textLabelTime;

    float tiempoPantalla = 2f;
    bool contandoTiempo = false;

    float tiempoDePartida = 0f;
    bool estaJugando = true;

    private void Start()
    {
        pantallaDerrota.SetActive(false);
    }

    private void Update()
    {

        if (contandoTiempo == true)
        {
            tiempoPantalla -= Time.deltaTime;

            if (tiempoPantalla <= 0f)
            {
                pantallaDerrota.SetActive(false);
                contandoTiempo = false;
            }
        }

        if (estaJugando == true)
        {
            tiempoDePartida += Time.deltaTime;
        }
        

        if (transform.position.y < -1 || Input.GetKeyDown(KeyCode.R))
        {
            transform.position = respawn.transform.position;
            print("Vuelve a empezar");

            pantallaDerrota.SetActive(true);
            tiempoPantalla = 1f;
            contandoTiempo = true;

            
            textLabelTime.text = tiempoDePartida.ToString();

        }
    }
}
