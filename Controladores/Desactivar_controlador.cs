using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desactivar_controlador : MonoBehaviour
{
    public GameObject Video;
    public GameObject Controlador;
    void Update()
    {
        if (Video.activeSelf == false) {
            Controlador.SetActive(false);
        }
    }
}
