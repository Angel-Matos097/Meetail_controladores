using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntercambioAics : MonoBehaviour
{
    public GameObject AicInicial;
    public GameObject AicMientrasSepasa;
public void cambiardeAic()
    {
        AicInicial.SetActive(false);
        AicMientrasSepasa.SetActive(true);
    }
}
