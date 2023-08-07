using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagarAic : MonoBehaviour
{
    [SerializeField] private GameObject objetoADesactivar;
    [SerializeField] private GameObject objetoADesactivar2;
    // Start is called before the first frame update
    public void DesactivarObjetoSeleccionado()
    {
        if (objetoADesactivar != null)
        {
                objetoADesactivar.SetActive(false);
            objetoADesactivar2.SetActive(false);
        }
    }
}
