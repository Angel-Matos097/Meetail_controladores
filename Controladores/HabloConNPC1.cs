using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HabloConNPC1 : MonoBehaviour
{
    public bool ya_hablo1 = false;
    public GameObject desactivar;

    public void activar1()
    {
        ya_hablo1 = true;
        desactivar.SetActive(false);
    }
}
