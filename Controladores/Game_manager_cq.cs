using UnityEngine;

public class Game_manager_cq : MonoBehaviour
{
    public GameObject aviso;

    private void Start()
    {
        CheckInternetConnection();
    }

    private void Update()
    {
        CheckInternetConnection();
    }

    private void CheckInternetConnection()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            PausarJuego();
            aviso.SetActive(true);
        }
    }

    private void PausarJuego()
    {
        Time.timeScale = 0f; // Establece la escala de tiempo a cero para detener todas las acciones del juego
        // Puedes agregar aquí cualquier lógica adicional para pausar el juego (por ejemplo, deshabilitar scripts de movimiento)
    }

    private void ReanudarJuego()
    {
        Time.timeScale = 1f;
        // Establece la escala de tiempo a 1 para reanudar el juego
        // Puedes agregar aquí cualquier lógica adicional para reanudar el juego (por ejemplo, habilitar scripts de movimiento)
    }

    public void boton_reanudar()
    {
        ReanudarJuego();
        aviso.SetActive(false);
    }
}
