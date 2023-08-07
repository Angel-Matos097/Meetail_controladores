using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Nuevo : MonoBehaviour
{
    public float radio = 1f;
    public LayerMask capaPersonaje;
    public GameObject iconoboton;
    public NPCConversation nPCConversation;
    public GameObject objetoADesactivar1;

    void Start()
    {
        iconoboton.SetActive(false);
    }

    void Update()
    {
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
            ConversationManager.Instance.EndConversation();
        }


        if (Input.GetKeyDown(KeyCode.E) && personajeCerca)
        {
            ConversationManager.Instance.StartConversation(nPCConversation);
            PersonajeMovimiento classInstance = FindObjectOfType<PersonajeMovimiento>();
            classInstance.velocidad = 0f;
            objetoADesactivar1.SetActive(false);
        }








    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radio);
    }
}
