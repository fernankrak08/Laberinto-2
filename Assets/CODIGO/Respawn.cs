
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject respawn;

    [SerializeField]
    GameObject pantallaDerrota;

    float tiempoPantalla = 1f;
    bool contandoTiempo = false;

    private void Start()
    {
        pantallaDerrota.SetActive(false);
    }

    private void Update()
    {
        if (transform.position.y < -1 || Input.GetKeyDown(KeyCode.R))
        {
            transform.position = respawn.transform.position;
            print("Vuelve a empezar");

            pantallaDerrota.SetActive(true);
            tiempoPantalla = 1f;
            contandoTiempo = true;
        }

        if (contandoTiempo == true)
        {
            tiempoPantalla -= Time.deltaTime;

            if (tiempoPantalla <= 0f)
            {
                pantallaDerrota.SetActive(false);
                contandoTiempo = false;
            }
        }
    }
}
