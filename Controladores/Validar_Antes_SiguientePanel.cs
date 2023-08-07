using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Validar_Antes_SiguientePanel : MonoBehaviour
{
    public GameObject palomitanomepaso;

    public GameObject palomitaizquierda1;
    public GameObject palomitaizquierda2;
    public GameObject palomitaizquierda3;

    public GameObject palomitaderecha1;
    public GameObject palomitaderecha2;
    public GameObject palomitaderecha3;

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public GameObject panel6;
    public GameObject panel7;
    public GameObject panel8;
    public GameObject panel9;
    public GameObject panel10;
    public GameObject panel11;
    public GameObject panel12;
    public GameObject panel13;
    public GameObject panel14;
    public GameObject panel15;

    public GameObject Intro;
    public GameObject outro;

    public GameObject canvas;

    public IEnumerator DelayedAction()
    {
            yield return new WaitForSeconds(20f); // Espera durante 2 segundos
            Application.Quit();
    }

    public IEnumerator DelayedAction1()
    {
        yield return new WaitForSeconds(3f); // Espera durante 2 segundos
    }


    public void validar_existe_respuesta()
    {

        if (Intro.activeSelf)
        {
            Intro.SetActive(false);
        }



        bool se_puedeir = false;
        if (palomitanomepaso.activeSelf)
        {
            se_puedeir = true;
        }

        if((palomitaizquierda1.activeSelf|| palomitaizquierda2.activeSelf|| palomitaizquierda3.activeSelf) && (palomitaderecha1.activeSelf || palomitaderecha2.activeSelf || palomitaderecha3.activeSelf))
        {
            se_puedeir = true;
        }


        if (se_puedeir == true)
        {
            palomitaderecha1.SetActive(false);
            palomitaderecha2.SetActive(false);
            palomitaderecha3.SetActive(false);
            palomitaizquierda1.SetActive(false);
            palomitaizquierda2.SetActive(false);
            palomitaizquierda3.SetActive(false);
            palomitanomepaso.SetActive(false);



            if (panel15.activeSelf)
            {

                panel15.SetActive(false);
                canvas.SetActive(false);

                StartCoroutine(DelayedAction1());
                outro.SetActive(true);
                StartCoroutine(DelayedAction());
                
            }

            if (panel14.activeSelf)
            {
                panel14.SetActive(false); panel15.SetActive(true);
            }
            if (panel13.activeSelf)
            {
                panel13.SetActive(false); panel14.SetActive(true);
            }
            if (panel12.activeSelf)
            {
                panel12.SetActive(false); panel13.SetActive(true);
            }
            if (panel11.activeSelf)
            {
                panel11.SetActive(false); panel12.SetActive(true);
            }
            if (panel10.activeSelf)
            {
                panel10.SetActive(false); panel11.SetActive(true);
            }
            if (panel9.activeSelf)
            {
                panel9.SetActive(false); panel10.SetActive(true);
            }
            if (panel8.activeSelf)
            {
                panel8.SetActive(false); panel9.SetActive(true);
            }
            if (panel7.activeSelf)
            {
                panel7.SetActive(false); panel8.SetActive(true);
            }
            if (panel6.activeSelf)
            {
                panel6.SetActive(false); panel7.SetActive(true);
            }
            if (panel5.activeSelf)
            {
                panel5.SetActive(false); panel6.SetActive(true);
            }
            if (panel4.activeSelf)
            {
                panel4.SetActive(false); panel5.SetActive(true);
            }
            if (panel3.activeSelf)
            {
                panel3.SetActive(false); panel4.SetActive(true);
            }
            if (panel2.activeSelf)
            {
                panel2.SetActive(false); panel3.SetActive(true);
            }
            if (panel1.activeSelf)
            {
                panel1.SetActive(false); panel2.SetActive(true);
            }


        }
    }
}
