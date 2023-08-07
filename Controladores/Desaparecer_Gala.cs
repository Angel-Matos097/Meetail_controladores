using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desaparecer_Gala : MonoBehaviour
{
    public int charlas = 0;
    public GameObject Gala;
    public bool Galanoesta = false;

    public void sumarcharla()
    {
        charlas += 1;
    }

    public void adiosGala()
    {
        if (charlas>1)
        {
            Gala.SetActive(false);
            Galanoesta = true;
        }
    }
}
