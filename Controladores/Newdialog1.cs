using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DialogueEditor;

public class Newdialog1 : MonoBehaviour
{
    public float radio = 1f;
    public LayerMask capaPersonaje;
    public GameObject iconoboton;
    public NPCConversation nPCConversation;
    public GameObject objetoADesactivar1;

    public Image targetObject;  // Objeto al que se le cambiará la imagen
    public Sprite newImage;  // Nueva imagen a asignar desde el inspector

    public static bool ya_esta_platicando = false;

    public void ChangeBackgroundImage()
    {
        if (targetObject != null && newImage != null)
        {
            targetObject.sprite = newImage;
        }
    }

    void Start()
    {
        iconoboton.SetActive(false);
        ya_esta_platicando = false;
    }

    void Update()
    {
        if (ya_esta_platicando == true) { Debug.Log("Ya esta platicando"); return; }
        //Debug.Log("Aun no esta platicando");

        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radio, capaPersonaje);

        bool personajeCerca = false;
        foreach (Collider2D collider in colliders)
        {
            if (collider.gameObject.CompareTag("Player")) // Verifica si el collider es del personaje
            {

                personajeCerca = true;
                break;
            }
        }

        if (personajeCerca)
        {
            iconoboton.SetActive(true);
        }
        else
        {
            iconoboton.SetActive(false);
        }


        if (Input.GetKeyDown(KeyCode.E) && personajeCerca && ya_esta_platicando == false)
        {
            ConversationManager.Instance.StartConversation(nPCConversation);
            PersonajeMovimiento classInstance = FindObjectOfType<PersonajeMovimiento>();
            WaypointMovimiento classInstance1 = FindObjectOfType<WaypointMovimiento>();
            classInstance.velocidad = 0f;
            objetoADesactivar1.SetActive(false);
            Input.ResetInputAxes();
            ChangeBackgroundImage();
            ya_esta_platicando = true;
            enabled = false;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radio);
    }
}
