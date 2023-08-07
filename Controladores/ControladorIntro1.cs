using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorIntro1 : MonoBehaviour
{
    public GameObject objetoAActivar1;
    public GameObject objetoAActivar2;
    public GameObject objetoAActivar3;
    public GameObject objetoAActivar4;

    public float tiempo1 = 5f;
    public float tiempo2 = 5f;
    public float tiempo3 = 5f;
    public float tiempo4 = 5f;

    private GameManager_ gameManagerScript; // Referencia al script GameManager_
    private bool gameManagerActive = false; // Estado del script GameManager_
    private float tiempoActivacionGameManager = 41f; // Tiempo en segundos para activar el script

    private void Start()
    {
        gameManagerScript = GetComponent<GameManager_>(); // Obtener la referencia al script GameManager_
        gameManagerScript.enabled = false; // Desactivar el script GameManager_ al inicio
    }

    private void Update()
    {
        tiempo1 -= Time.deltaTime;
        tiempo2 -= Time.deltaTime;
        tiempo3 -= Time.deltaTime;
        tiempo4 -= Time.deltaTime;
        tiempoActivacionGameManager -= Time.deltaTime;

        if (tiempo1 <= 0)
        {
            Invoke("ActivarObjeto1", 0);
        }
        if (tiempo2 <= 0)
        {
            Invoke("ActivarObjeto2", 0);
        }
        if (tiempo3 <= 0)
        {
            Invoke("ActivarObjeto3", 0);
        }
        if (tiempo4 <= 0)
        {
            Invoke("ActivarObjeto4", 0);
        }

        if (!gameManagerActive && tiempoActivacionGameManager <= 0)
        {
            gameManagerScript.enabled = true; // Activar el script GameManager_
            gameManagerActive = true; // Actualizar el estado del script
        }
    }

    void ActivarObjeto1()
    {
        objetoAActivar1.SetActive(true);
    }
    void ActivarObjeto2()
    {
        objetoAActivar2.SetActive(true);
    }
    void ActivarObjeto3()
    {
        objetoAActivar3.SetActive(true);
    }
    void ActivarObjeto4()
    {
        objetoAActivar4.SetActive(true);
    }
}
