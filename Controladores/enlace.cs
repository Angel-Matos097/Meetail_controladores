using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enlace : MonoBehaviour
{
    public void OpenExternalLink()
    {
        Application.OpenURL("https://drive.google.com/file/d/1ps6uFL1MKfMlyZdjrzJkjX19ezXn8sAD/view?usp=sharing");
    }
}
