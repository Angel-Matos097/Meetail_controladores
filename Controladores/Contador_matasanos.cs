using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador_matasanos : MonoBehaviour
{
    public int contador_matasanos = 0;
    GameObject AicPuerta;
    public void hablaron2vecesalmenos()
    {
        contador_matasanos += 1;
    }

}
