using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contar_charlas2 : MonoBehaviour
{
    public bool contar_conversaciones_npcs2 = false;
    public GameObject desactivar;
    public void activar2()
    {
        contar_conversaciones_npcs2 = true;
        desactivar.SetActive(false);
    }
}
