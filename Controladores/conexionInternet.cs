using UnityEngine;

public class validarconexion : MonoBehaviour
{
    public static validarconexion Instance { get; private set; }

    private bool isGamePaused = false;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void PausarJuego()
    {
        Time.timeScale = 0f; // Pausar el tiempo del juego
        isGamePaused = true;
        // Aquí puedes agregar cualquier lógica adicional para pausar el juego
    }

    public void ReanudarJuego()
    {
        Time.timeScale = 1f; // Reanudar el tiempo del juego
        isGamePaused = false;
        // Aquí puedes agregar cualquier lógica adicional para reanudar el juego
    }
}
