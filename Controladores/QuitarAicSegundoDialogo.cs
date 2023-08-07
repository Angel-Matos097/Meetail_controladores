using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarAicSegundoDialogo : MonoBehaviour
{
    public GameObject Aic;

public void Dejar_salir_nivel(){
        if (Aic.activeSelf)
        {
            Aic.SetActive(false);
        }
    }

}
