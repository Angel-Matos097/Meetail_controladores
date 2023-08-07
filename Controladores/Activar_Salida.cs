using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar_Salida : MonoBehaviour
{
    public GameObject activar;
    public GameObject desactivar;

    void Update()
    {
        GameObject obj1 = GameObject.Find("Gala");
        GameObject obj2 = GameObject.Find("Tao");

        if ((obj1 == null || !obj1.activeSelf) && (obj2 == null || !obj2.activeSelf))
        {
            activar.SetActive(true);
            desactivar.SetActive(false);
        }
    }
}
