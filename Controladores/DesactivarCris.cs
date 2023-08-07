using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarCris : MonoBehaviour
{
    public GameObject Cris;

    public void AdiosCris()
    {
        Cris.SetActive(false);
    }
}
