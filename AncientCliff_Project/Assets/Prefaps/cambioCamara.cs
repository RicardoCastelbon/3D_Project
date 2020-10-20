using UnityEngine;
using System.Collections;

public class cambioCamara : MonoBehaviour
{

    public GameObject camaraAnimada;
    public GameObject controlador;

    // Use this for initialization
    void Start()
    {
        controlador.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            camaraAnimada.SetActive(true);
            controlador.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            controlador.SetActive(true);
            camaraAnimada.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}
