using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetirarAics : MonoBehaviour
{
    [Header("Desactivar_Aics_introduccion")]
    public GameObject Aic_abajo;
    public GameObject Aic_puerta;
    public GameObject Aic_puerta_reducido;

    [Header("Activar_Aic_dialogo_nosaliraun")]
    public GameObject Aic_puerta_reducido_desactivar;
    public GameObject Aic_puerta_dialogo_nosaliraun;

    [Header("Quitar_Aic_salirdelNivel")]
    public GameObject Quitar_Aic_dejar_salir;


    public void Desactivar_Aics_introduccion()
    {
        Aic_abajo.SetActive(false);
        Aic_puerta.SetActive(false);
        Aic_puerta_reducido.SetActive(true);
    }

    public void Activar_Aic_dialogo_nosaliraun()
    {
        Aic_puerta_reducido_desactivar.SetActive(false);
        Aic_puerta_dialogo_nosaliraun.SetActive(true);
    }

    public void Quitar_Aic_salirdelNivel()
    {
        Quitar_Aic_dejar_salir.SetActive(false);
    }




}
