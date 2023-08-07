using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desaparecer_Mao : MonoBehaviour
{
    public GameObject Tao;
    public bool taonoesta=false;

    public void AdiosTao()
    {
        Tao.SetActive(false);
        taonoesta = true;
    }
}
