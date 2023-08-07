using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contar_charlas : MonoBehaviour
{
    public bool contar_conversaciones_npcs=false;
    public GameObject desactivar;
    public void activar()
    {
        contar_conversaciones_npcs = true;
        desactivar.SetActive(false);

    }

}
