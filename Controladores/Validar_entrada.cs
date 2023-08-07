using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Validar_entrada : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;

    public GameObject activar;
    public GameObject desact;


    private void Update()
    {
        bool variableBool = object1.GetComponent<Contar_charlas>().contar_conversaciones_npcs;
        bool variableBoo2 = object2.GetComponent<Contar_charlas2>().contar_conversaciones_npcs2;
        bool variableBoo3 = object3.GetComponent<Contar_charlas3>().contar_conversaciones_npcs3;
        if (variableBool && variableBoo2 && variableBoo3) { 
            
            activar.SetActive(true); desact.SetActive(false);


        }
    }

    

    
}
