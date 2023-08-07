using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel2_controlador : MonoBehaviour
{
    [Header("Verificar_si_ya_sehabloconNPCs")]
    public GameObject NPC1;
    public GameObject NPC2;
    public GameObject NPC3;
    public bool tomo_buena_desicion = false;

    [Header("Aic_bloqueadorPuerta")]
    public GameObject Aic;

    [Header("Aic_intermedio2_3")]
    public GameObject Aic_intermedio2_3;

    [Header("Desactivar_entrada_a_enfermeria")]
    public GameObject entrada_enfermeria;


    public bool ya_activados_antes = false;


    public void activar_npcs()
    {
        if (!ya_activados_antes)
        {
            NPC1.SetActive(true);
            NPC2.SetActive(true);
            NPC3.SetActive(true);
            ya_activados_antes = true;
        }

    }

    public void desactivarNPC1()
    {
        NPC1.SetActive(false);
    }
    public void desactivarNPC2()
    {
        NPC2.SetActive(false);
    }
    public void desactivarNPC3()
    {
        NPC3.SetActive(false);
    }
    public void tomobuenadesicion()
    {
        tomo_buena_desicion = true;
    }


    public void dejar_salir_del_nivel()
    {
        if(tomo_buena_desicion)
        {
            if (NPC1.activeSelf == false && NPC2.activeSelf == false && NPC3.activeSelf == false) {
                Aic.SetActive(false);
                Aic_intermedio2_3.SetActive(true);
                entrada_enfermeria.SetActive(false);
            }
            
        }
    }



    void Update()
    {
        dejar_salir_del_nivel();
    }
}
