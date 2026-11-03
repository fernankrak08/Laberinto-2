
using TMPro;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField]
    GameObject respawn;

    [SerializeField]
    GameObject pantallaDerrota;

    [SerializeField]
    TextMeshProUGUI textLabelTime1;

    [SerializeField]
    TextMeshProUGUI textLabelTime2;

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
            int minutos = Mathf.FloorToInt(tiempoDePartida / 60);
            int segundos = Mathf.FloorToInt(tiempoDePartida % 60);

            textLabelTime2.text = string.Format("{0:00}:{1:00}", minutos, segundos);
        }

        if (transform.position.y < -1 || Input.GetKeyDown(KeyCode.R))
        {
            transform.position = respawn.transform.position;
            print("Vuelve a empezar");

            pantallaDerrota.SetActive(true);
            tiempoPantalla = 1f;
            contandoTiempo = true;

            textLabelTime1.text = tiempoDePartida.ToString("f2");

            int minutos = Mathf.FloorToInt(tiempoDePartida / 60);
            int segundos = Mathf.FloorToInt(tiempoDePartida % 60);

            textLabelTime2.text = string.Format("{0:00}:{1:00}", minutos, segundos);
        }
    }
}

