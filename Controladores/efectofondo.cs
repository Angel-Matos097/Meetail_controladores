using UnityEngine;
using UnityEngine.UI;

public class efectofondo : MonoBehaviour
{
    public Image targetImage;
    public Sprite[] images;

    private int currentImageIndex = 0;
    private float timer = 0f;
    public float timeBetweenSwaps = 5f;

    private void Start()
    {
        // Verifica que el objeto contenga una referencia al componente Image
        if (targetImage == null)
        {
            targetImage = GetComponent<Image>();
        }

        // Comprueba que se hayan asignado al menos dos im�genes
        if (images.Length < 2)
        {
            Debug.LogError("Asigna al menos dos im�genes al arreglo 'Images' en el Inspector.");
            enabled = false;
            return;
        }

        // Establece la primera imagen
        targetImage.sprite = images[currentImageIndex];
    }

    private void Update()
    {
        // Actualiza el temporizador
        timer += Time.deltaTime;

        // Verifica si ha pasado el tiempo suficiente para cambiar la imagen
        if (timer >= timeBetweenSwaps)
        {
            // Incrementa el �ndice de imagen actual
            currentImageIndex++;

            // Comprueba si se ha alcanzado el final del arreglo de im�genes
            if (currentImageIndex >= images.Length)
            {
                currentImageIndex = 0;
            }

            // Cambia la imagen
            targetImage.sprite = images[currentImageIndex];

            // Reinicia el temporizador
            timer = 0f;
        }
    }
}
