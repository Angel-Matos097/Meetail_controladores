using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;

public class cargar_ruta_basededatos : MonoBehaviour
{
   // private string connectionString = "SERVER=bkavmo1lvkp5ncfdvufq-mysql.services.clever-cloud.com;DATABASE=bkavmo1lvkp5ncfdvufq;UID=uaq07ye50qy0etah;PWD=QPYpAYOn37FQtNKwUwQ8;";

    public void SaveDataToDatabase(string matricula, string npc, int n_dialogo, int[,] matriz)
    {
        string host = "bkavmo1lvkp5ncfdvufq-mysql.services.clever-cloud.com";
        int port = 21249;
        string database = "bkavmo1lvkp5ncfdvufq";
        string username = "uaq07ye50qy0etah";
        string password = "QPYpAYOn37FQtNKwUwQ8";
        string connectionString = $"Server={host};Port={port};Database={database};Uid={username};Pwd={password};";


        // string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlCommand command = connection.CreateCommand();

        // Insertar los datos en la base de datos sin protección vs inyección de datos
        command.CommandText = "INSERT INTO dialogos_elecciones (matricula, id_npc, numero_dialogo, N1_O1,N1_O2,N1_O3,N1_O4,N1_O5,N1_O6,N1_O7,N1_O8,N1_O9,N1_O10,N1_O11,N1_O12,N2_O1,N2_O2,N2_O3,N2_O4,N2_O5,N2_O6,N2_O7,N2_O8,N2_O9,N2_O10,N2_O11,N2_O12,N3_O1,N3_O2,N3_O3,N3_O4,N3_O5,N3_O6,N3_O7,N3_O8,N3_O9,N3_O10,N3_O11,N3_O12,N4_O1,N4_O2,N4_O3,N4_O4,N4_O5,N4_O6,N4_O7,N4_O8,N4_O9,N4_O10,N4_O11,N4_O12,N5_O1,N5_O2,N5_O3,N5_O4,N5_O5,N5_O6,N5_O7,N5_O8,N5_O9,N5_O10,N5_O11,N5_O12,N6_O1,N6_O2,N6_O3,N6_O4,N6_O5,N6_O6,N6_O7,N6_O8,N6_O9,N6_O10,N6_O11,N6_O12,N7_O1,N7_O2,N7_O3,N7_O4,N7_O5,N7_O6,N7_O7,N7_O8,N7_O9,N7_O10,N7_O11,N7_O12,N8_O1,N8_O2,N8_O3,N8_O4,N8_O5,N8_O6,N8_O7,N8_O8,N8_O9,N8_O10,N8_O11,N8_O12,N9_O1,N9_O2,N9_O3,N9_O4,N9_O5,N9_O6,N9_O7,N9_O8,N9_O9,N9_O10,N9_O11,N9_O12,N10_O1,N10_O2,N10_O3,N10_O4,N10_O5,N10_O6,N10_O7,N10_O8,N10_O9,N10_O10,N10_O11,N10_O12,N11_O1,N11_O2,N11_O3,N11_O4,N11_O5,N11_O6,N11_O7,N11_O8,N11_O9,N11_O10,N11_O11,N11_O12,N12_O1,N12_O2,N12_O3,N12_O4,N12_O5,N12_O6,N12_O7,N12_O8,N12_O9,N12_O10,N12_O11,N12_O12,N13_O1,N13_O2,N13_O3,N13_O4,N13_O5,N13_O6,N13_O7,N13_O8,N13_O9,N13_O10,N13_O11,N13_O12) " +
                              "VALUES ('" + matricula + "', '" + npc + "', " + n_dialogo + ", " +

                              matriz[0, 0] + ", " +  matriz[0, 1] + ", " +  matriz[0, 2] + ", " +  matriz[0, 3] + ", " +  matriz[0, 4] + ", " + matriz[0, 5] + ", " + matriz[0, 6] + ", " + matriz[0, 7] + ", " + matriz[0, 8] + ", " + matriz[0, 9] + ", " + matriz[0, 10] + ", " + matriz[0, 11] + ", " + 
                              matriz[1, 0] + ", " +  matriz[1, 1] + ", " +  matriz[1, 2] + ", " +  matriz[1, 3] + ", " +  matriz[1, 4] + ", " + matriz[1, 5] + ", " + matriz[1, 6] + ", " + matriz[1, 7] + ", " + matriz[1, 8] + ", " + matriz[1, 9] + ", " + matriz[1, 10] + ", " + matriz[1, 11] + ", " + 
                              matriz[2, 0] + ", " +  matriz[2, 1] + ", " +  matriz[2, 2] + ", " +  matriz[2, 3] + ", " +  matriz[2, 4] + ", " + matriz[2, 5] + ", " + matriz[2, 6] + ", " + matriz[2, 7] + ", " + matriz[2, 8] + ", " + matriz[2, 9] + ", " + matriz[2, 10] + ", " + matriz[2, 11] + ", " + 
                              matriz[3, 0] + ", " +  matriz[3, 1] + ", " +  matriz[3, 2] + ", " +  matriz[3, 3] + ", " +  matriz[3, 4] + ", " + matriz[3, 5] + ", " + matriz[3, 6] + ", " + matriz[3, 7] + ", " + matriz[3, 8] + ", " + matriz[3, 9] + ", " + matriz[3, 10] + ", " + matriz[3, 11] + ", " + 
                              matriz[4, 0] + ", " +  matriz[4, 1] + ", " +  matriz[4, 2] + ", " +  matriz[4, 3] + ", " +  matriz[4, 4] + ", " + matriz[4, 5] + ", " + matriz[4, 6] + ", " + matriz[4, 7] + ", " + matriz[4, 8] + ", " + matriz[4, 9] + ", " + matriz[4, 10] + ", " + matriz[4, 11] + ", " + 
                              matriz[5, 0] + ", " +  matriz[5, 1] + ", " +  matriz[5, 2] + ", " +  matriz[5, 3] + ", " +  matriz[5, 4] + ", " + matriz[5, 5] + ", " + matriz[5, 6] + ", " + matriz[5, 7] + ", " + matriz[5, 8] + ", " + matriz[5, 9] + ", " + matriz[5, 10] + ", " + matriz[5, 11] + ", " + 
                              matriz[6, 0] + ", " +  matriz[6, 1] + ", " +  matriz[6, 2] + ", " +  matriz[6, 3] + ", " +  matriz[6, 4] + ", " + matriz[6, 5] + ", " + matriz[6, 6] + ", " + matriz[6, 7] + ", " + matriz[6, 8] + ", " + matriz[6, 9] + ", " + matriz[6, 10] + ", " + matriz[6, 11] + ", " + 
                              matriz[7, 0] + ", " +  matriz[7, 1] + ", " +  matriz[7, 2] + ", " +  matriz[7, 3] + ", " +  matriz[7, 4] + ", " + matriz[7, 5] + ", " + matriz[7, 6] + ", " + matriz[7, 7] + ", " + matriz[7, 8] + ", " + matriz[7, 9] + ", " + matriz[7, 10] + ", " + matriz[7, 11] + ", " + 
                              matriz[8, 0] + ", " +  matriz[8, 1] + ", " +  matriz[8, 2] + ", " +  matriz[8, 3] + ", " +  matriz[8, 4] + ", " + matriz[8, 5] + ", " + matriz[8, 6] + ", " + matriz[8, 7] + ", " + matriz[8, 8] + ", " + matriz[8, 9] + ", " + matriz[8, 10] + ", " + matriz[8, 11] + ", " + 
                              matriz[9, 0] + ", " +  matriz[9, 1] + ", " +  matriz[9, 2] + ", " +  matriz[9, 3] + ", " +  matriz[9, 4] + ", " + matriz[9, 5] + ", " + matriz[9, 6] + ", " + matriz[9, 7] + ", " + matriz[9, 8] + ", " + matriz[9, 9] + ", " + matriz[9, 10] + ", " + matriz[9, 11] + ", " + 
                              matriz[10, 0] + ", " + matriz[10, 1] + ", " + matriz[10, 2] + ", " + matriz[10, 3] + ", " + matriz[10, 4] + ", " +matriz[10, 5] + ", " + matriz[10, 6] + ", " + matriz[10, 7] + ", " + matriz[10, 8] + ", " + matriz[10, 9] + ", " + matriz[10, 10] + ", " + matriz[10, 11] + ", " + 
                              matriz[11, 0] + ", " + matriz[11, 1] + ", " + matriz[11, 2] + ", " + matriz[11, 3] + ", " + matriz[11, 4] + ", " +matriz[11, 5] + ", " + matriz[11, 6] + ", " + matriz[11, 7] + ", " + matriz[11, 8] + ", " + matriz[11, 9] + ", " + matriz[11, 10] + ", " + matriz[11, 11] + ", " + 
                              matriz[12, 0] + ", " + matriz[12, 1] + ", " + matriz[12, 2] + ", " + matriz[12, 3] + ", " + matriz[12, 4] + ", " +matriz[12, 5] + ", " + matriz[12, 6] + ", " + matriz[12, 7] + ", " + matriz[12, 8] + ", " + matriz[12, 9] + ", " + matriz[12, 10] + ", " + matriz[12, 11] + ")";


        try
        {
            connection.Open();
            command.ExecuteNonQuery();
            Debug.Log("Datos guardados en la base de datos exitosamente.");
        }
        catch (MySqlException ex)
        {
            Debug.LogError("Error al guardar los datos en la base de datos: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }
}



