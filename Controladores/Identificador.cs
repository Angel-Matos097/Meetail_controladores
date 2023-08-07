using UnityEngine;

public class Identificador : MonoBehaviour
{
    private bool cercaDeNPC = false;
    private string nombreguardado;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colisión con: " + other.gameObject.name);
        if (other.gameObject.CompareTag("NPC"))
        {
            Debug.Log("DENTRO");
            cercaDeNPC = true;

            // establecer el script a activar según el nombre del NPC
            if (other.gameObject.name == "NPC1")
            {
                nombreguardado = "NPC1";
            }
            else if (other.gameObject.name == "NPC2")
            {
                nombreguardado = "NPC2";
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            Debug.Log("FUERA");
            cercaDeNPC = false;
        }
    }

    private void Update()
    {
        if (cercaDeNPC && Input.GetKeyDown(KeyCode.E))
        {
            if (nombreguardado.Equals("NPC1")) { Debug.Log("Activar dialogo1"); }
            if (nombreguardado.Equals("NPC2")) { Debug.Log("Activar dialogo2"); }
        }
        
    }
}