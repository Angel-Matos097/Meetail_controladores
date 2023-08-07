using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HabloConNPC3 : MonoBehaviour
{
    public bool ya_hablo3 = false;
    public GameObject desactivar;
    public void activar3()
    {
        ya_hablo3 = true;
        desactivar.SetActive(false);
    }
}
