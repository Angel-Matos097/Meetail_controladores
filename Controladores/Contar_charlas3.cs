using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contar_charlas3 : MonoBehaviour
{
    public bool contar_conversaciones_npcs3 = false;
    public GameObject desactivar;
    public void activar3()
    {
        contar_conversaciones_npcs3 = true;
        desactivar.SetActive(false);
    }
}
