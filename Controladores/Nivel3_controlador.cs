using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel3_controlador : MonoBehaviour
{
    [Header("Verificar_si_ya_sehabloconNPCs")]
    public GameObject NPC1;
    public bool tomo_buena_desicion = false;
    public GameObject Gala;

    [Header("Puerta_desactivada")]
    public GameObject Puerta_desactivada;

    public void desactivarNPC1()
    {
        NPC1.SetActive(false);
    }

    public void tomobuenadesicion()
    {
        tomo_buena_desicion = true;
        Gala.SetActive(false);
    }


    public void dejar_salir_del_nivel()
    {
        if (tomo_buena_desicion)
        {
            if (NPC1.activeSelf == false)
            {
                Puerta_desactivada.SetActive(true);
            }

        }
    }



    void Update()
    {
        dejar_salir_del_nivel();
    }
}
