using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarAriel : MonoBehaviour
{
    public GameObject Ariel;

    public void AdiosAriel()
    {
        Ariel.SetActive(false);
    }
}
