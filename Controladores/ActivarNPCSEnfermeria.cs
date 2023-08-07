using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarNPCSEnfermeria : MonoBehaviour
{
    public GameObject NPC1;
    public GameObject NPC2;
    public GameObject NPC3;



    public void ActivarTodos()
    {
        Contador_matasanos script1 = FindObjectOfType<Contador_matasanos>();
        int variableEntera = script1.contador_matasanos;
        if (variableEntera<1)
        {
            NPC1.SetActive(true);
            NPC2.SetActive(true);
            NPC3.SetActive(true);
        }
    }

}
