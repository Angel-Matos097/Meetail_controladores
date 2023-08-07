using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesapareceAic : MonoBehaviour
{
    public GameObject Aic;
    public GameObject Aic2;

    public void desaparecerAic()
    {
        Aic.SetActive(false);
        Aic2.SetActive(true);
    }
}
