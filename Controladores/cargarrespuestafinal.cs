using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;
using TMPro;
using System;

public class cargarrespuestafinal : MonoBehaviour
{
    [Header("INTRO")]
    public GameObject intro;

    [Header("PREGUNTAS")]
    public GameObject Q1;
    public GameObject Q2;
    public GameObject Q3;
    public GameObject Q4;
    public GameObject Q5;
    public GameObject Q6;
    public GameObject Q7;
    public GameObject Q8;
    public GameObject Q9;
    public GameObject Q10;
    public GameObject Q11;
    public GameObject Q12;
    public GameObject Q13;
    public GameObject Q14;
    public GameObject Q15;

    [Header("RESPUESTAS FRECUENCIA")]
    public GameObject F1;
    public GameObject F2;
    public GameObject F3;

    [Header("RESPUESTAS INTENSIDAD")]
    public GameObject I1;
    public GameObject I2;
    public GameObject I3;

    [Header("RESPUESTA 0")]
    public GameObject No_Ocurrio;

    [Header("VARIABLES PARA RESPUESTAS FRECUENCIA")]
    public int q1_f = 0;
    public int q2_f = 0;
    public int q3_f = 0;
    public int q4_f = 0;
    public int q5_f = 0;
    public int q6_f = 0;
    public int q7_f = 0;
    public int q8_f = 0;
    public int q9_f = 0;
    public int q10_f = 0;
    public int q11_f = 0;
    public int q12_f = 0;
    public int q13_f = 0;
    public int q14_f = 0;
    public int q15_f = 0;

    [Header("VARIABLES PARA RESPUESTAS INTENSIDAD")]
    public int q1_i = 0;
    public int q2_i = 0;
    public int q3_i = 0;
    public int q4_i = 0;
    public int q5_i = 0;
    public int q6_i = 0;
    public int q7_i = 0;
    public int q8_i = 0;
    public int q9_i = 0;
    public int q10_i = 0;
    public int q11_i = 0;
    public int q12_i = 0;
    public int q13_i = 0;
    public int q14_i = 0;
    public int q15_i = 0;

    private bool ya_se_cargo = false;

    void Start()
    {
        string matricula = PlayerPrefs.GetString("MatriculaUsuario");
        Debug.Log("Matricula: "+ matricula);
    }


    public void agregarrespuesta()
    {
        if (Q1.activeSelf)
        {
            if (No_Ocurrio.activeSelf) { q1_f = 0; }
            else
            {
                if (F1.activeSelf) { q1_f = 1; }
                else
                {
                    if (F2.activeSelf) { q1_f = 2; }
                    else
                    {
                        if (F3.activeSelf) { q1_f = 3; }
                    }
                }
            }

            if (No_Ocurrio.activeSelf) { q1_i = 0; }
            else
            {
                if (I1.activeSelf) { q1_i = 1; }
                else
                {
                    if (I2.activeSelf) { q1_i = 2; }
                    else
                    {
                        if (I3.activeSelf) { q1_i = 3; }
                    }
                }
            }
        }


        if (Q2.activeSelf)
        {
            if (No_Ocurrio.activeSelf) { q2_f = 0; }
            else
            {
                if (F1.activeSelf) { q2_f = 1; }
                else
                {
                    if (F2.activeSelf) { q2_f = 2; }
                    else
                    {
                        if (F3.activeSelf) { q2_f = 3; }
                    }
                }
            }

            if (No_Ocurrio.activeSelf) { q2_i = 0; }
            else
            {
                if (I1.activeSelf) { q2_i = 1; }
                else
                {
                    if (I2.activeSelf) { q2_i = 2; }
                    else
                    {
                        if (I3.activeSelf) { q2_i = 3; }
                    }
                }
            }
        }


        if (Q3.activeSelf)
        {
            if (No_Ocurrio.activeSelf) { q3_f = 0; }
            else
            {
                if (F1.activeSelf) { q3_f = 1; }
                else
                {
                    if (F2.activeSelf) { q3_f = 2; }
                    else
                    {
                        if (F3.activeSelf) { q3_f = 3; }
                    }
                }
            }

            if (No_Ocurrio.activeSelf) { q3_i = 0; }
            else
            {
                if (I1.activeSelf) { q3_i = 1; }
                else
                {
                    if (I2.activeSelf) { q3_i = 2; }
                    else
                    {
                        if (I3.activeSelf) { q3_i = 3; }
                    }
                }
            }
        }


        if (Q4.activeSelf)
        {
            if (No_Ocurrio.activeSelf) { q4_f = 0; }
            else
            {
                if (F1.activeSelf) { q4_f = 1; }
                else
                {
                    if (F2.activeSelf) { q4_f = 2; }
                    else
                    {
                        if (F3.activeSelf) { q4_f = 3; }
                    }
                }
            }

            if (No_Ocurrio.activeSelf) { q4_i = 0; }
            else
            {
                if (I1.activeSelf) { q4_i = 1; }
                else
                {
                    if (I2.activeSelf) { q4_i = 2; }
                    else
                    {
                        if (I3.activeSelf) { q4_i = 3; }
                    }
                }
            }
        }

        if (Q5.activeSelf)
        {
            if (No_Ocurrio.activeSelf) { q5_f = 0; }
            else
            {
                if (F1.activeSelf) { q5_f = 1; }
                else
                {
                    if (F2.activeSelf) { q5_f = 2; }
                    else
                    {
                        if (F3.activeSelf) { q5_f = 3; }
                    }
                }
            }

            if (No_Ocurrio.activeSelf) { q5_i = 0; }
            else
            {
                if (I1.activeSelf) { q5_i = 1; }
                else
                {
                    if (I2.activeSelf) { q5_i = 2; }
                    else
                    {
                        if (I3.activeSelf) { q5_i = 3; }
                    }
                }
            }
        }

        if (Q6.activeSelf)
        {
            if (No_Ocurrio.activeSelf) { q6_f = 0; }
            else
            {
                if (F1.activeSelf) { q6_f = 1; }
                else
                {
                    if (F2.activeSelf) { q6_f = 2; }
                    else
                    {
                        if (F3.activeSelf) { q6_f = 3; }
                    }
                }
            }

            if (No_Ocurrio.activeSelf) { q6_i = 0; }
            else
            {
                if (I1.activeSelf) { q6_i = 1; }
                else
                {
                    if (I2.activeSelf) { q6_i = 2; }
                    else
                    {
                        if (I3.activeSelf) { q6_i = 3; }
                    }
                }
            }
        }

        if (Q7.activeSelf)
        {
            if (No_Ocurrio.activeSelf) { q7_f = 0; }
            else
            {
                if (F1.activeSelf) { q7_f = 1; }
                else
                {
                    if (F2.activeSelf) { q7_f = 2; }
                    else
                    {
                        if (F3.activeSelf) { q7_f = 3; }
                    }
                }
            }

            if (No_Ocurrio.activeSelf) { q7_i = 0; }
            else
            {
                if (I1.activeSelf) { q7_i = 1; }
                else
                {
                    if (I2.activeSelf) { q7_i = 2; }
                    else
                    {
                        if (I3.activeSelf) { q7_i = 3; }
                    }
                }
            }
        }

        if (Q8.activeSelf)
        {
            if (No_Ocurrio.activeSelf) { q8_f = 0; }
            else
            {
                if (F1.activeSelf) { q8_f = 1; }
                else
                {
                    if (F2.activeSelf) { q8_f = 2; }
                    else
                    {
                        if (F3.activeSelf) { q8_f = 3; }
                    }
                }
            }

            if (No_Ocurrio.activeSelf) { q8_i = 0; }
            else
            {
                if (I1.activeSelf) { q8_i = 1; }
                else
                {
                    if (I2.activeSelf) { q8_i = 2; }
                    else
                    {
                        if (I3.activeSelf) { q8_i = 3; }
                    }
                }
            }
        }

        if (Q9.activeSelf)
        {
            if (No_Ocurrio.activeSelf) { q9_f = 0; }
            else
            {
                if (F1.activeSelf) { q9_f = 1; }
                else
                {
                    if (F2.activeSelf) { q9_f = 2; }
                    else
                    {
                        if (F3.activeSelf) { q9_f = 3; }
                    }
                }
            }

            if (No_Ocurrio.activeSelf) { q9_i = 0; }
            else
            {
                if (I1.activeSelf) { q9_i = 1; }
                else
                {
                    if (I2.activeSelf) { q9_i = 2; }
                    else
                    {
                        if (I3.activeSelf) { q9_i = 3; }
                    }
                }
            }
        }

        if (Q10.activeSelf)
        {
            if (No_Ocurrio.activeSelf) { q10_f = 0; }
            else
            {
                if (F1.activeSelf) { q10_f = 1; }
                else
                {
                    if (F2.activeSelf) { q10_f = 2; }
                    else
                    {
                        if (F3.activeSelf) { q10_f = 3; }
                    }
                }
            }

            if (No_Ocurrio.activeSelf) { q10_i = 0; }
            else
            {
                if (I1.activeSelf) { q10_i = 1; }
                else
                {
                    if (I2.activeSelf) { q10_i = 2; }
                    else
                    {
                        if (I3.activeSelf) { q10_i = 3; }
                    }
                }
            }
        }

        if (Q11.activeSelf)
        {
            if (No_Ocurrio.activeSelf) { q11_f = 0; }
            else
            {
                if (F1.activeSelf) { q11_f = 1; }
                else
                {
                    if (F2.activeSelf) { q11_f = 2; }
                    else
                    {
                        if (F3.activeSelf) { q11_f = 3; }
                    }
                }
            }

            if (No_Ocurrio.activeSelf) { q11_i = 0; }
            else
            {
                if (I1.activeSelf) { q11_i = 1; }
                else
                {
                    if (I2.activeSelf) { q11_i = 2; }
                    else
                    {
                        if (I3.activeSelf) { q11_i = 3; }
                    }
                }
            }
        }

        if (Q12.activeSelf)
        {
            if (No_Ocurrio.activeSelf) { q12_f = 0; }
            else
            {
                if (F1.activeSelf) { q12_f = 1; }
                else
                {
                    if (F2.activeSelf) { q12_f = 2; }
                    else
                    {
                        if (F3.activeSelf) { q12_f = 3; }
                    }
                }
            }

            if (No_Ocurrio.activeSelf) { q12_i = 0; }
            else
            {
                if (I1.activeSelf) { q12_i = 1; }
                else
                {
                    if (I2.activeSelf) { q12_i = 2; }
                    else
                    {
                        if (I3.activeSelf) { q12_i = 3; }
                    }
                }
            }
        }

        if (Q13.activeSelf)
        {
            if (No_Ocurrio.activeSelf) { q13_f = 0; }
            else
            {
                if (F1.activeSelf) { q13_f = 1; }
                else
                {
                    if (F2.activeSelf) { q13_f = 2; }
                    else
                    {
                        if (F3.activeSelf) { q13_f = 3; }
                    }
                }
            }

            if (No_Ocurrio.activeSelf) { q13_i = 0; }
            else
            {
                if (I1.activeSelf) { q13_i = 1; }
                else
                {
                    if (I2.activeSelf) { q13_i = 2; }
                    else
                    {
                        if (I3.activeSelf) { q13_i = 3; }
                    }
                }
            }
        }


        if (Q14.activeSelf)
        {
            if (No_Ocurrio.activeSelf) { q14_f = 0; }
            else
            {
                if (F1.activeSelf) { q14_f = 1; }
                else
                {
                    if (F2.activeSelf) { q14_f = 2; }
                    else
                    {
                        if (F3.activeSelf) { q14_f = 3; }
                    }
                }
            }

            if (No_Ocurrio.activeSelf) { q14_i = 0; }
            else
            {
                if (I1.activeSelf) { q14_i = 1; }
                else
                {
                    if (I2.activeSelf) { q14_i = 2; }
                    else
                    {
                        if (I3.activeSelf) { q14_i = 3; }
                    }
                }
            }
        }

        if (Q15.activeSelf)
        {
            if (No_Ocurrio.activeSelf) { q15_f = 0; }
            else
            {
                if (F1.activeSelf) { q15_f = 1; }
                else
                {
                    if (F2.activeSelf) { q15_f = 2; }
                    else
                    {
                        if (F3.activeSelf) { q15_f = 3; }
                    }
                }
            }

            if (No_Ocurrio.activeSelf) { q15_i = 0; }
            else
            {
                if (I1.activeSelf) { q15_i = 1; }
                else
                {
                    if (I2.activeSelf) { q15_i = 2; }
                    else
                    {
                        if (I3.activeSelf) { q15_i = 3; }
                    }
                }
            }
        }



        if (Q15.activeSelf)
        {
            cargarrespuestas();
        }
    }

    // Esto se ejecutará cuando se cargue el script
    public void cargarrespuestas()
    {
        if (ya_se_cargo == false)
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

            string matricula = PlayerPrefs.GetString("MatriculaUsuario");
            Debug.Log("Matricula: " + matricula);

            string query = "INSERT INTO respuestas_cdq_final (matricula, r1_i, r2_i, r3_i, r4_i, r5_i, r6_i, r7_i, r8_i, r9_i, r10_i, r11_i, r12_i, r13_i, r14_i, r15_i, r1_f, r2_f, r3_f, r4_f, r5_f, r6_f, r7_f, r8_f, r9_f, r10_f, r11_f, r12_f, r13_f, r14_f, r15_f) VALUES (@matricula, @q1_i, @q2_i, @q3_i, @q4_i, @q5_i, @q6_i, @q7_i, @q8_i, @q9_i, @q10_i, @q11_i, @q12_i, @q13_i, @q14_i, @q15_i, @q1_f, @q2_f, @q3_f, @q4_f, @q5_f, @q6_f, @q7_f, @q8_f, @q9_f, @q10_f, @q11_f, @q12_f, @q13_f, @q14_f, @q15_f)";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@matricula", matricula);
            cmd.Parameters.AddWithValue("@q1_i", q1_i);
            cmd.Parameters.AddWithValue("@q2_i", q2_i);
            cmd.Parameters.AddWithValue("@q3_i", q3_i);
            cmd.Parameters.AddWithValue("@q4_i", q4_i);
            cmd.Parameters.AddWithValue("@q5_i", q5_i);
            cmd.Parameters.AddWithValue("@q6_i", q6_i);
            cmd.Parameters.AddWithValue("@q7_i", q7_i);
            cmd.Parameters.AddWithValue("@q8_i", q8_i);
            cmd.Parameters.AddWithValue("@q9_i", q9_i);
            cmd.Parameters.AddWithValue("@q10_i", q10_i);
            cmd.Parameters.AddWithValue("@q11_i", q11_i);
            cmd.Parameters.AddWithValue("@q12_i", q12_i);
            cmd.Parameters.AddWithValue("@q13_i", q13_i);
            cmd.Parameters.AddWithValue("@q14_i", q14_i);
            cmd.Parameters.AddWithValue("@q15_i", q15_i);
            cmd.Parameters.AddWithValue("@q1_f", q1_f);
            cmd.Parameters.AddWithValue("@q2_f", q2_f);
            cmd.Parameters.AddWithValue("@q3_f", q3_f);
            cmd.Parameters.AddWithValue("@q4_f", q4_f);
            cmd.Parameters.AddWithValue("@q5_f", q5_f);
            cmd.Parameters.AddWithValue("@q6_f", q6_f);
            cmd.Parameters.AddWithValue("@q7_f", q7_f);
            cmd.Parameters.AddWithValue("@q8_f", q8_f);
            cmd.Parameters.AddWithValue("@q9_f", q9_f);
            cmd.Parameters.AddWithValue("@q10_f", q10_f);
            cmd.Parameters.AddWithValue("@q11_f", q11_f);
            cmd.Parameters.AddWithValue("@q12_f", q12_f);
            cmd.Parameters.AddWithValue("@q13_f", q13_f);
            cmd.Parameters.AddWithValue("@q14_f", q14_f);
            cmd.Parameters.AddWithValue("@q15_f", q15_f);

            try
            {
                cmd.ExecuteNonQuery();
                Debug.Log("Datos insertados correctamente");
            }
            catch (MySqlException ex)
            {
                Debug.Log("Error al insertar datos: " + ex.Message);
            }

            // Cerrar la conexión a la base de datos
            connection.Close();
        }
    }































}
