using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar_NPCs : MonoBehaviour
{
    public GameObject NPC1;
    public GameObject NPC2;
    public GameObject NPC3;

    public void activar_todos()
    {
        NPC1.SetActive(true);
        NPC2.SetActive(true);
        NPC3.SetActive(true);
    }

}
