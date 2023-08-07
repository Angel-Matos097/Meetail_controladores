using UnityEngine;
using UnityEngine.UI;

public class cargarbackground : MonoBehaviour
{
    public Image backgroundImage;  // Imagen de fondo que se asignará desde el inspector

    public Sprite background;  // Imagen de fondo que se asignará desde el inspector

    private void Start()
    {
        if (backgroundImage != null && background != null)
        {
            backgroundImage.sprite = background;
        }
    }
}
