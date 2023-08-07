using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HabloConNPC2 : MonoBehaviour
{
    public bool ya_hablo2 = false;
    public GameObject desactivar;

    public void activar2()
    {
        ya_hablo2 = true;
        desactivar.SetActive(false);
    }
}
