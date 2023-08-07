using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorIntro : MonoBehaviour
{
    public GameObject objetoADesactivar;
    public float tiempo = 5f;

    void Update()
    {
        tiempo -= Time.deltaTime;

        if (tiempo <= 0)
        {
            Invoke("DesactivarObjeto", 0);
        }
    }

    void DesactivarObjeto()
    {
        objetoADesactivar.SetActive(false);
    }
}
