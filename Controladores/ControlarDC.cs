using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlarDC : MonoBehaviour
{
    public float estadisticaAdivinacion = 0;
    public float estadisticaDicotomico = 0;
    public float estadisticaMaxMin = 0;

    public TextMeshProUGUI AdivinacionStat;
    public TextMeshProUGUI DicotomicoStat;
    public TextMeshProUGUI MaxMinStat;

    public TextMeshProUGUI validarAdivinacion1;
    public TextMeshProUGUI validarAdivinacion2;
    public TextMeshProUGUI validarAdivinacion3;

    public TextMeshProUGUI validarDicotomico1;
    public TextMeshProUGUI validarDicotomico2;
    public TextMeshProUGUI validarDicotomico3;

    public TextMeshProUGUI validarMaxMin1;
    public TextMeshProUGUI validarMaxmin2;
    public TextMeshProUGUI validarMaxmin3;

    void Start()
    {

    }
    void Update()
    {
        Adivinacion();
        PensamientoDicotomico();
        MaximizarMinimizar();

      
    }

    public void Adivinacion(){

        int  inseguridad= int.Parse(validarAdivinacion1.text);
        int  negatividad= int.Parse(validarAdivinacion2.text);
        int  realismo= int.Parse(validarAdivinacion3.text);

        float promedio1 = inseguridad + negatividad + realismo;
        promedio1 = promedio1 / 3;
        estadisticaAdivinacion = promedio1;

        AdivinacionStat.text = estadisticaAdivinacion.ToString("F2");
    }
    public void PensamientoDicotomico()
    {
        int perfeccionismo = int.Parse(validarDicotomico1.text);
        int victimismo = int.Parse(validarDicotomico2.text);
        int estres = int.Parse(validarDicotomico3.text);

        float promedio2 = perfeccionismo + victimismo + estres;
        promedio2 = promedio2 / 3;
        estadisticaDicotomico = promedio2;

        DicotomicoStat.text = estadisticaDicotomico.ToString("F2");
    }
    public void MaximizarMinimizar()
    {
        int dogmatismo = int.Parse(validarMaxMin1.text);
        int intolerancia = int.Parse(validarMaxmin2.text);
        int flexibilidad = int.Parse(validarMaxmin3.text);

        float promedio3 = dogmatismo + intolerancia + flexibilidad;
        promedio3 = promedio3 / 3;
        estadisticaMaxMin = promedio3;

        MaxMinStat.text = estadisticaMaxMin.ToString("F2");
    }
}
