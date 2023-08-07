using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Validar_salida : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject contador;


    public GameObject desact;
    public GameObject desact2;


    public GameObject NPC1;
    public GameObject NPC2;
    public GameObject NPC3;

    public GameObject AicIntermedio;


    void Update()
    {
        bool variableBool = object1.GetComponent<HabloConNPC1>().ya_hablo1;
        bool variableBoo2 = object2.GetComponent<HabloConNPC2>().ya_hablo2;
        bool variableBoo3 = object3.GetComponent<HabloConNPC3>().ya_hablo3;
        int variableint = contador.GetComponent<Contador_matasanos>().contador_matasanos;

        if (variableBool && variableBoo2 && variableBoo3 && variableint >1)
        {
            desact.SetActive(false);
            desact2.SetActive(false);
            AicIntermedio.SetActive(true);
        }

        if(variableBool && variableBoo2 && variableBoo3)
        {
            NPC1.SetActive(false);
            NPC2.SetActive(false);
            NPC2.SetActive(false);
        }
    }
}
