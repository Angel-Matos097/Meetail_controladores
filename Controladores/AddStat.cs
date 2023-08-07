using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddStat : MonoBehaviour
{
    public int estadistica = 0;
    public TextMeshProUGUI textoEstadistica;

    void Start()
    {
        
    }
    void Update()
    {
        textoEstadistica.text = estadistica.ToString();
    }

    public void Add1()
    {
        estadistica += 1;
    }
    public void Add2()
    {
        estadistica += 2;
    }
    public void Add3()
    {
        estadistica += 3;
    }
    public void Add4()
    {
        estadistica += 4;
    }
    public void Add5()
    {
        estadistica += 5;
    }

    public void Rest1()
    {
        estadistica -= 1;
    }
    public void Rest2()
    {
        estadistica -= 2;
    }
    public void Rest3()
    {
        estadistica -= 3;
    }
    public void Rest4()
    {
        estadistica -= 4;
    }
    public void Rest5()
    {
        estadistica -= 5;
    }
}
