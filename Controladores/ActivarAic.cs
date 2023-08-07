using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarAic : MonoBehaviour
{
    [SerializeField] private GameObject objetoAActivar;

    public void ActivarObjetoSeleccionado()
    {
            objetoAActivar.SetActive(true);
       
    }
}
