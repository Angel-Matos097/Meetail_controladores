using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargraEscena : MonoBehaviour
{
    public GameObject Outro;
    public void llamar()
    {
        StartCoroutine(DelayedAction());
    }
    public IEnumerator DelayedAction()
    {
        if (Outro.activeSelf)
        {
            yield return new WaitForSeconds(2f); // Espera durante 2 segundos
            SceneManager.LoadScene("Scene");
        }}}
