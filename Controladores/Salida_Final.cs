using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salida_Final : MonoBehaviour
{
    public GameObject desactivar;

    public GameObject Ariel;
    public GameObject Mao;
    public GameObject Cris;


    void Update()
    {
        if (!Ariel.activeSelf && !Mao.activeSelf && !Cris.activeSelf)
        {
            desactivar.SetActive(false);
        }

        if (Ariel.activeSelf) { desactivar.SetActive(true); }
        if (Mao.activeSelf) { desactivar.SetActive(true); }
        if (Cris.activeSelf) { desactivar.SetActive(true); }
    }

}
