using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarMao : MonoBehaviour
{
    public GameObject Mao;

    public void AdiosMao()
    {
        Mao.SetActive(false);
    }
}
