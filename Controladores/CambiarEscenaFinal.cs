using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using MySql.Data.MySqlClient;

public class CambiarEscenaFinal : MonoBehaviour
{
    public GameObject estadisticas;

    public TextMeshProUGUI inseguridad;
    public TextMeshProUGUI negatividad;
    public TextMeshProUGUI realismo;

    public TextMeshProUGUI perfeccionismo;
    public TextMeshProUGUI victimismo;
    public TextMeshProUGUI estres;

    public TextMeshProUGUI dogmatismo;
    public TextMeshProUGUI intolerancia;
    public TextMeshProUGUI flexibilidad;

    public TextMeshProUGUI adivinacion;
    public TextMeshProUGUI dicotomico;
    public TextMeshProUGUI autoetiquetado;


    private string resultado_inseguridad;
    private string resultado_negatividad;
    private string resultado_realismo;
    private string resultado_perfeccionismo;
    private string resultado_victimismo;
    private string resultado_estres;
    private string resultado_dogmatismo;
    private string resultado_intolerancia;
    private string resultado_flexibilidad;

    private string resultado_adivinacion;
    private string resultado_dicotomico;
    private string resultado_autoetiquetado;










    public void iralFinal()
    {
        estadisticas.SetActive(true);

        resultado_inseguridad = inseguridad.text;
        int valor_inseguridad;
        int.TryParse(resultado_inseguridad, out valor_inseguridad);
        Debug.Log("Valor_inseguridad: " + resultado_inseguridad);

        resultado_negatividad = negatividad.text;
        int valor_negatividad;
        int.TryParse(resultado_negatividad, out valor_negatividad);
        Debug.Log("Valor_negatividad: " + resultado_negatividad);

        resultado_realismo = realismo.text;
        int valor_realismo;
        int.TryParse(resultado_realismo, out valor_realismo);
        Debug.Log("Valor_realismo: " + resultado_realismo);

        resultado_perfeccionismo = perfeccionismo.text;
        int valor_perfeccionismo;
        int.TryParse(resultado_perfeccionismo, out valor_perfeccionismo);
        Debug.Log("Valor_perfeccionismo: " + resultado_perfeccionismo);

        resultado_victimismo = victimismo.text;
        int valor_victimismo;
        int.TryParse(resultado_victimismo, out valor_victimismo);
        Debug.Log("Valor_victimismo: " + resultado_victimismo);

        resultado_estres = estres.text;
        int valor_estres;
        int.TryParse(resultado_estres, out valor_estres);
        Debug.Log("Valor_estres: " + resultado_estres);

        resultado_dogmatismo = dogmatismo.text;
        int valor_dogmatismo;
        int.TryParse(resultado_dogmatismo, out valor_dogmatismo);
        Debug.Log("Valor_dogmatismo: " + resultado_dogmatismo);

        resultado_intolerancia = intolerancia.text;
        int valor_intolerancia;
        int.TryParse(resultado_intolerancia, out valor_intolerancia);
        Debug.Log("Valor_intolerancia: " + resultado_intolerancia);

        resultado_flexibilidad = flexibilidad.text;
        int valor_flexibilidad;
        int.TryParse(resultado_flexibilidad, out valor_flexibilidad);
        Debug.Log("Valor_flexibilidad: " + resultado_flexibilidad);


        resultado_adivinacion = adivinacion.text;
        float valor_adivinacion;
        float.TryParse(resultado_adivinacion, out valor_adivinacion);
        Debug.Log("Valor_adivinacion: " + resultado_adivinacion);

        resultado_dicotomico = dicotomico.text;
        float valor_dicotomico;
        float.TryParse(resultado_dicotomico, out valor_dicotomico);
        Debug.Log("Valor_dicotomico: " + resultado_dicotomico);

        resultado_autoetiquetado = autoetiquetado.text;
        float valor_autoetiquetado;
        float.TryParse(resultado_autoetiquetado, out valor_autoetiquetado);
        Debug.Log("Valor_autoetiquetado: " + resultado_autoetiquetado);

        estadisticas.SetActive(false);


        string host = "bkavmo1lvkp5ncfdvufq-mysql.services.clever-cloud.com";
        int port = 21249;
        string database = "bkavmo1lvkp5ncfdvufq";
        string username = "uaq07ye50qy0etah";
        string password = "QPYpAYOn37FQtNKwUwQ8";
        string connectionString = $"Server={host};Port={port};Database={database};Uid={username};Pwd={password};";


        // string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        MySqlConnection connection = new MySqlConnection(connectionString);

        try
        {
            connection.Open();
            Debug.Log("Conectado a la base de datos");
        }
        catch (MySqlException ex)
        {
            Debug.Log("Error al conectarse a la base de datos: " + ex.Message);
        }
        string matricula = PlayerPrefs.GetString("MatriculaUsuario");

        string query = "INSERT INTO Estadisticas (matricula, inseguridad, negatividad, realismo, perfeccionismo, victimismo, estres, dogmatismo, intolerancia, flexibilidad, adivinacion, dicotomico, autoetiquetado) " +
                       "VALUES (@matricula, @inseguridad, @negatividad, @realismo, @perfeccionismo, @victimismo, @estres, @dogmatismo, @intolerancia, @flexibilidad, @adivinacion, @dicotomico, @autoetiquetado)";

        MySqlCommand command = new MySqlCommand(query, connection);
        command.Parameters.AddWithValue("@matricula", matricula);
        command.Parameters.AddWithValue("@inseguridad", valor_negatividad);
        command.Parameters.AddWithValue("@negatividad", valor_negatividad);
        command.Parameters.AddWithValue("@realismo", valor_realismo);
        command.Parameters.AddWithValue("@perfeccionismo", valor_perfeccionismo);
        command.Parameters.AddWithValue("@victimismo", valor_victimismo);
        command.Parameters.AddWithValue("@estres", valor_estres);
        command.Parameters.AddWithValue("@dogmatismo", valor_dogmatismo);
        command.Parameters.AddWithValue("@intolerancia", valor_intolerancia);
        command.Parameters.AddWithValue("@flexibilidad", valor_flexibilidad);
        command.Parameters.AddWithValue("@adivinacion", valor_adivinacion);
        command.Parameters.AddWithValue("@dicotomico", valor_dicotomico);
        command.Parameters.AddWithValue("@autoetiquetado", valor_autoetiquetado);


        try
        {
            command.ExecuteNonQuery();
            Debug.Log("Datos insertados correctamente");
        }
        catch (MySqlException ex)
        {
            Debug.Log("Error al insertar datos: " + ex.Message);
        }

        // Cerrar la conexión a la base de datos
        connection.Close();









        SceneManager.LoadScene("CDQ_Final");
    }
}
