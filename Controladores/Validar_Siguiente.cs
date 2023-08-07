using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using MySql.Data.MySqlClient;

public class Validar_Siguiente : MonoBehaviour
{
    public GameObject palomitanomepaso;
    public GameObject palomitaizquierda1;
    public GameObject palomitaizquierda2;
    public GameObject palomitaizquierda3;

    public GameObject palomitaderecha1;
    public GameObject palomitaderecha2;
    public GameObject palomitaderecha3;

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public GameObject panel6;
    public GameObject panel7;
    public GameObject panel8;
    public GameObject panel9;
    public GameObject panel10;
    public GameObject panel11;
    public GameObject panel12;
    public GameObject panel13;
    public GameObject panel14;
    public GameObject panel15;

    public GameObject Intro;
    public GameObject TextoIntro;
    public GameObject outro;

    public GameObject textInputObject;
    private TMP_InputField textInput;

    public GameObject mensajeerror;

    public GameObject frase;

    private bool ya_se_cargo = false;

    private void Start()
    {
        textInput = textInputObject.GetComponent<TMP_InputField>();
    }

    public bool validar()
    {
        bool esValida = true;
        string text = textInput.text;

        if (text.Length == 9)
        {
            // Verificar si la cadena empieza con "LE" (mayúscula o minúscula)
            if (!text.StartsWith("E", StringComparison.OrdinalIgnoreCase))
            {
                esValida = false;
            }

            // Verificar la longitud de la cadena
            if (text.Length != 9)
            {
                esValida = false;
            }

            // Verificar si los dos primeros dígitos representan un año válido
            string añoStr = text.Substring(1, 2);
            if (!int.TryParse(añoStr, out int año) || año < 16 || año > 23)
            {
                esValida = false;
            }

            // Verificar si los segundos dos dígitos son 01 o 08
            string mesStr = text.Substring(3, 2);
            if (mesStr != "01" && mesStr != "08")
            {
                esValida = false;
            }

            // Verificar si los últimos cuatro dígitos son números
            string numeroStr = text.Substring(5, 4);
            if (!int.TryParse(numeroStr, out int numero))
            {
                esValida = false;
            }


        }
        else { esValida = false; }
        return esValida;
    }

    // Esto se ejecutará cuando se cargue el script
    public void cargarprueba()
    {
        if (validar() && ya_se_cargo==false)
        {
            ya_se_cargo = true;

            string host = "bkavmo1lvkp5ncfdvufq-mysql.services.clever-cloud.com";
            int port = 21249;
            string database = "bkavmo1lvkp5ncfdvufq";
            string username = "uaq07ye50qy0etah";
            string password = "QPYpAYOn37FQtNKwUwQ8";

            string connectionString = $"Server={host};Port={port};Database={database};Uid={username};Pwd={password};";

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

            string text = textInput.text;
            // Insertar un nuevo registro en la tabla "Matriculas"
            string query = "INSERT INTO Matriculas (matricula) VALUES ('" + text + "')";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                cmd.ExecuteNonQuery();
                Debug.Log("Datos insertados correctamente");
                ya_se_cargo = true;
            }
            catch (MySqlException ex)
            {
                Debug.Log("Error al insertar datos: " + ex.Message);
            }

            // Cerrar la conexión a la base de datos
            connection.Close();
        }
        else
        {
            Debug.Log("Cadena no valida");
        }
    }
    public IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(0f);
        panel15.SetActive(false); outro.SetActive(true);
    }
    public void validar_existe_respuesta_()
    {

        if (frase.activeSelf)
        {
            frase.SetActive(false);
        }


        if (Intro.activeSelf)
        {
            if (validar())
            {
                cargarprueba();
                Intro.SetActive(false);
                frase.SetActive(true);
            }
            else
            {
                mensajeerror.SetActive(true);
                TextoIntro.SetActive(false);
             }
        }






            bool se_puedeir = false;
        if (palomitanomepaso.activeSelf)
        {
            se_puedeir = true;
        }

        if ((palomitaizquierda1.activeSelf || palomitaizquierda2.activeSelf || palomitaizquierda3.activeSelf) && (palomitaderecha1.activeSelf || palomitaderecha2.activeSelf || palomitaderecha3.activeSelf))
        {
            se_puedeir = true;
        }


        if (se_puedeir == true)
        {
            palomitaderecha1.SetActive(false);
            palomitaderecha2.SetActive(false);
            palomitaderecha3.SetActive(false);
            palomitaizquierda1.SetActive(false);
            palomitaizquierda2.SetActive(false);
            palomitaizquierda3.SetActive(false);
            palomitanomepaso.SetActive(false);


            if (panel15.activeSelf)
            {
                StartCoroutine(DelayedAction());
            }
            if (panel14.activeSelf)
            {
                panel14.SetActive(false); panel15.SetActive(true);
            }
            if (panel13.activeSelf)
            {
                panel13.SetActive(false); panel14.SetActive(true);
            }
            if (panel12.activeSelf)
            {
                panel12.SetActive(false); panel13.SetActive(true);
            }
            if (panel11.activeSelf)
            {
                panel11.SetActive(false); panel12.SetActive(true);
            }
            if (panel10.activeSelf)
            {
                panel10.SetActive(false); panel11.SetActive(true);
            }
            if (panel9.activeSelf)
            {
                panel9.SetActive(false); panel10.SetActive(true);
            }
            if (panel8.activeSelf)
            {
                panel8.SetActive(false); panel9.SetActive(true);
            }
            if (panel7.activeSelf)
            {
                panel7.SetActive(false); panel8.SetActive(true);
            }
            if (panel6.activeSelf)
            {
                panel6.SetActive(false); panel7.SetActive(true);
            }
            if (panel5.activeSelf)
            {
                panel5.SetActive(false); panel6.SetActive(true);
            }
            if (panel4.activeSelf)
            {
                panel4.SetActive(false); panel5.SetActive(true);
            }
            if (panel3.activeSelf)
            {
                panel3.SetActive(false); panel4.SetActive(true);
            }
            if (panel2.activeSelf)
            {
                panel2.SetActive(false); panel3.SetActive(true);
            }
            if (panel1.activeSelf)
            {
                panel1.SetActive(false); panel2.SetActive(true);
            }


        }
    }




    public void probar()
    {
        string connectionString = "server=bkavmo1lvkp5ncfdvufq-mysql.services.clever-cloud.com;database=bkavmo1lvkp5ncfdvufq;uid=uaq07ye50qy0etah;password=QPYpAYOn37FQtNKwUwQ8;";

        // Crear la conexión
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Conectado a la base de datos");

                // Insertar un nuevo registro en la tabla "Matriculas"
                string matricula = "Ejemplo123";
                string query = "INSERT INTO Matriculas (matricula) VALUES (@matricula)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@matricula", matricula);
                command.ExecuteNonQuery();

                Console.WriteLine("Dato insertado correctamente");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al conectar o insertar datos: " + ex.Message);
            }
        }
    }





}
