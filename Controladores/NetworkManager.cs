using UnityEngine;

public class NetworkManager : MonoBehaviour
{
    public float checkInterval = 5f;

    private bool hasInternetConnection = true;

    private void Start()
    {
        InvokeRepeating("CheckInternetConnection", 0f, checkInterval);
    }

    private void CheckInternetConnection()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            // No hay conexi�n a internet
            Debug.Log("No hay conexi�n a internet.");

            if (hasInternetConnection)
            {
                hasInternetConnection = false;
                GameManager.Instance.PausarJuego();
            }
        }
        else
        {
            if (!hasInternetConnection)
            {
                hasInternetConnection = true;
                GameManager.Instance.ReanudarJuego();
            }
        }
    }
}