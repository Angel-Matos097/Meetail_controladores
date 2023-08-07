using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class validarguardadodematricula : MonoBehaviour
{
    void Update()
    {
        string miVariableRecuperada = PlayerPrefs.GetString("MatriculaUsuario");
        Debug.Log(miVariableRecuperada);
    }
}
