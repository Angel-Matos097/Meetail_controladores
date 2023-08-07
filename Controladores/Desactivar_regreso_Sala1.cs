using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desactivar_regreso_Sala1 : MonoBehaviour
{
    public GameObject regreso;

    public void noregresaras()
    {
        regreso.SetActive(false);
    }
}
