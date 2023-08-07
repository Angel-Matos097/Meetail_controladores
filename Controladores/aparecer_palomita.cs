using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aparecer_palomita : MonoBehaviour
{
    public GameObject palomitanomepaso;

    public GameObject palomitaizquierda1;
    public GameObject palomitaizquierda2;
    public GameObject palomitaizquierda3;

    public GameObject palomitaderecha1;
    public GameObject palomitaderecha2;
    public GameObject palomitaderecha3;


    public void PalomitaNoPaso()
    {
        palomitanomepaso.SetActive(true);
        palomitaizquierda1.SetActive(false);
        palomitaizquierda2.SetActive(false);
        palomitaizquierda3.SetActive(false);
        palomitaderecha1.SetActive(false);
        palomitaderecha2.SetActive(false);
        palomitaderecha3.SetActive(false);
    }


    public void Activarpalomitaizquierda1()
    {
        palomitaizquierda1.SetActive(true);
        palomitaizquierda2.SetActive(false);
        palomitaizquierda3.SetActive(false);
        palomitanomepaso.SetActive(false);
    }
    public void Activarpalomitaizquierda2()
    {
        palomitaizquierda1.SetActive(false);
        palomitaizquierda2.SetActive(true);
        palomitaizquierda3.SetActive(false);
        palomitanomepaso.SetActive(false);
    }
    public void Activarpalomitaizquierda3()
    {
        palomitaizquierda1.SetActive(false);
        palomitaizquierda2.SetActive(false);
        palomitaizquierda3.SetActive(true);
        palomitanomepaso.SetActive(false);
    }
    public void Activarpalomitaderecha1()
    {
        palomitaderecha1.SetActive(true);
        palomitaderecha2.SetActive(false);
        palomitaderecha3.SetActive(false);
        palomitanomepaso.SetActive(false);
    }
    public void Activarpalomitaderecha2()
    {
        palomitaderecha1.SetActive(false);
        palomitaderecha2.SetActive(true);
        palomitaderecha3.SetActive(false);
        palomitanomepaso.SetActive(false);
    }
    public void Activarpalomitaderecha3()
    {
        palomitaderecha1.SetActive(false);
        palomitaderecha2.SetActive(false);
        palomitaderecha3.SetActive(true);
        palomitanomepaso.SetActive(false);
    }
    
}
