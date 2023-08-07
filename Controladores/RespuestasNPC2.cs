using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;
using System;

public class RespuestasNPC2 : MonoBehaviour
{
    public static int cantidad_de_dialogo = 0;

    public int[,] respuestas;

    public void ____________________________________PrintMatriz()
    {
        string matris = "";
        matris += "Número de dialogos:" + cantidad_de_dialogo + "\n";
        matris += "Repuestas:";
        for (int i = 0; i < respuestas.GetLength(0); i++)
        {
            matris += "\n";
            for (int j = 0; j < respuestas.GetLength(1); j++)
            {
                matris += "|" + respuestas[i, j];
            }
        }
        Debug.Log(matris);

        // Obtener los datos necesarios para la conexión y los parámetros
        string matricula = PlayerPrefs.GetString("MatriculaUsuario");
        string npc = "Aic_intro_Puerta";

        // Crear una instancia de DatabaseManager
        cargar_ruta_basededatos dbManager = new cargar_ruta_basededatos();

        // Llamar al método SaveDataToDatabase pasando los datos y la matriz
        dbManager.SaveDataToDatabase(matricula, npc, cantidad_de_dialogo, respuestas);
    }

    public void ____________________________________aumentarcantidaddialogo()
    {
        cantidad_de_dialogo += 1;

        int rows = 13; // Número de filas
        int columns = 12; // Número de columnas
        respuestas = new int[rows, columns]; // Inicializar la matriz con las dimensiones
                                             // Asignar valores a las filas de la matriz
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                respuestas[i, j] = 0;
            }
        }
    }

    #region guardado_de_respuestas
    public void ___________________1_1() { respuestas[0, 0] = 1; }
    public void ___________________1_2() { respuestas[0, 1] = 1; }
    public void ___________________1_3() { respuestas[0, 2] = 1; }
    public void ___________________1_4() { respuestas[0, 3] = 1; }
    public void ___________________1_5() { respuestas[0, 4] = 1; }
    public void ___________________1_6() { respuestas[0, 5] = 1; }
    public void ___________________1_7() { respuestas[0, 6] = 1; }
    public void ___________________1_8() { respuestas[0, 7] = 1; }
    public void ___________________1_9() { respuestas[0, 8] = 1; }
    public void ___________________1_10() { respuestas[0, 9] = 1; }
    public void ___________________1_11() { respuestas[0, 10] = 1; }
    public void ___________________1_12() { respuestas[0, 11] = 1; }



    public void __________________2_1() { respuestas[1, 0] = 1; }
    public void __________________2_2() { respuestas[1, 1] = 1; }
    public void __________________2_3() { respuestas[1, 2] = 1; }
    public void __________________2_4() { respuestas[1, 3] = 1; }
    public void __________________2_5() { respuestas[1, 4] = 1; }
    public void __________________2_6() { respuestas[1, 5] = 1; }
    public void __________________2_7() { respuestas[1, 6] = 1; }
    public void __________________2_8() { respuestas[1, 7] = 1; }
    public void __________________2_9() { respuestas[1, 8] = 1; }
    public void __________________2_10() { respuestas[1, 9] = 1; }
    public void __________________2_11() { respuestas[1, 10] = 1; }
    public void __________________2_12() { respuestas[1, 11] = 1; }


    public void _________________3_1() { respuestas[2, 0] = 1; }
    public void _________________3_2() { respuestas[2, 1] = 1; }
    public void _________________3_3() { respuestas[2, 2] = 1; }
    public void _________________3_4() { respuestas[2, 3] = 1; }
    public void _________________3_5() { respuestas[2, 4] = 1; }
    public void _________________3_6() { respuestas[2, 5] = 1; }
    public void _________________3_7() { respuestas[2, 6] = 1; }
    public void _________________3_8() { respuestas[2, 7] = 1; }
    public void _________________3_9() { respuestas[2, 8] = 1; }
    public void _________________3_10() { respuestas[2, 9] = 1; }
    public void _________________3_11() { respuestas[2, 10] = 1; }
    public void _________________3_12() { respuestas[2, 11] = 1; }
    public void _________________3_13() { respuestas[2, 12] = 1; }

    public void ________________4_1() { respuestas[3, 0] = 1; }
    public void ________________4_2() { respuestas[3, 1] = 1; }
    public void ________________4_3() { respuestas[3, 2] = 1; }
    public void ________________4_4() { respuestas[3, 3] = 1; }
    public void ________________4_5() { respuestas[3, 4] = 1; }
    public void ________________4_6() { respuestas[3, 5] = 1; }
    public void ________________4_7() { respuestas[3, 6] = 1; }
    public void ________________4_8() { respuestas[3, 7] = 1; }
    public void ________________4_9() { respuestas[3, 8] = 1; }
    public void ________________4_10() { respuestas[3, 9] = 1; }
    public void ________________4_11() { respuestas[3, 10] = 1; }
    public void ________________4_12() { respuestas[3, 11] = 1; }


    public void _______________5_1() { respuestas[4, 0] = 1; }
    public void _______________5_2() { respuestas[4, 1] = 1; }
    public void _______________5_3() { respuestas[4, 2] = 1; }
    public void _______________5_4() { respuestas[4, 3] = 1; }
    public void _______________5_5() { respuestas[4, 4] = 1; }
    public void _______________5_6() { respuestas[4, 5] = 1; }
    public void _______________5_7() { respuestas[4, 6] = 1; }
    public void _______________5_8() { respuestas[4, 7] = 1; }
    public void _______________5_9() { respuestas[4, 8] = 1; }
    public void _______________5_10() { respuestas[4, 9] = 1; }
    public void _______________5_11() { respuestas[4, 10] = 1; }
    public void _______________5_12() { respuestas[4, 11] = 1; }

    public void ______________6_1() { respuestas[5, 0] = 1; }
    public void ______________6_2() { respuestas[5, 1] = 1; }
    public void ______________6_3() { respuestas[5, 2] = 1; }
    public void ______________6_4() { respuestas[5, 3] = 1; }
    public void ______________6_5() { respuestas[5, 4] = 1; }
    public void ______________6_6() { respuestas[5, 5] = 1; }
    public void ______________6_7() { respuestas[5, 6] = 1; }
    public void ______________6_8() { respuestas[5, 7] = 1; }
    public void ______________6_9() { respuestas[5, 8] = 1; }
    public void ______________6_10() { respuestas[5, 9] = 1; }
    public void ______________6_11() { respuestas[5, 10] = 1; }
    public void ______________6_12() { respuestas[5, 11] = 1; }


    public void _____________7_1() { respuestas[6, 0] = 1; }
    public void _____________7_2() { respuestas[6, 1] = 1; }
    public void _____________7_3() { respuestas[6, 2] = 1; }
    public void _____________7_4() { respuestas[6, 3] = 1; }
    public void _____________7_5() { respuestas[6, 4] = 1; }
    public void _____________7_6() { respuestas[6, 5] = 1; }
    public void _____________7_7() { respuestas[6, 6] = 1; }
    public void _____________7_8() { respuestas[6, 7] = 1; }
    public void _____________7_9() { respuestas[6, 8] = 1; }
    public void _____________7_10() { respuestas[6, 9] = 1; }
    public void _____________7_11() { respuestas[6, 10] = 1; }
    public void _____________7_12() { respuestas[6, 11] = 1; }


    public void ____________8_1() { respuestas[7, 0] = 1; }
    public void ____________8_2() { respuestas[7, 1] = 1; }
    public void ____________8_3() { respuestas[7, 2] = 1; }
    public void ____________8_4() { respuestas[7, 3] = 1; }
    public void ____________8_5() { respuestas[7, 4] = 1; }
    public void ____________8_6() { respuestas[7, 5] = 1; }
    public void ____________8_7() { respuestas[7, 6] = 1; }
    public void ____________8_8() { respuestas[7, 7] = 1; }
    public void ____________8_9() { respuestas[7, 8] = 1; }
    public void ____________8_10() { respuestas[7, 9] = 1; }
    public void ____________8_11() { respuestas[7, 10] = 1; }
    public void ____________8_12() { respuestas[7, 11] = 1; }

    public void ___________9_1() { respuestas[8, 0] = 1; }
    public void ___________9_2() { respuestas[8, 1] = 1; }
    public void ___________9_3() { respuestas[8, 2] = 1; }
    public void ___________9_4() { respuestas[8, 3] = 1; }
    public void ___________9_5() { respuestas[8, 4] = 1; }
    public void ___________9_6() { respuestas[8, 5] = 1; }
    public void ___________9_7() { respuestas[8, 6] = 1; }
    public void ___________9_8() { respuestas[8, 7] = 1; }
    public void ___________9_9() { respuestas[8, 8] = 1; }
    public void ___________9_10() { respuestas[8, 9] = 1; }
    public void ___________9_11() { respuestas[8, 10] = 1; }
    public void ___________9_12() { respuestas[8, 11] = 1; }

    public void __________10_1() { respuestas[9, 0] = 1; }
    public void __________10_2() { respuestas[9, 1] = 1; }
    public void __________10_3() { respuestas[9, 2] = 1; }
    public void __________10_4() { respuestas[9, 3] = 1; }
    public void __________10_5() { respuestas[9, 4] = 1; }
    public void __________10_6() { respuestas[9, 5] = 1; }
    public void __________10_7() { respuestas[9, 6] = 1; }
    public void __________10_8() { respuestas[9, 7] = 1; }
    public void __________10_9() { respuestas[9, 8] = 1; }
    public void __________10_10() { respuestas[9, 9] = 1; }
    public void __________10_11() { respuestas[9, 10] = 1; }
    public void __________10_12() { respuestas[9, 11] = 1; }

    public void _________11_1() { respuestas[10, 0] = 1; }
    public void _________11_2() { respuestas[10, 1] = 1; }
    public void _________11_3() { respuestas[10, 2] = 1; }
    public void _________11_4() { respuestas[10, 3] = 1; }
    public void _________11_5() { respuestas[10, 4] = 1; }
    public void _________11_6() { respuestas[10, 5] = 1; }
    public void _________11_7() { respuestas[10, 6] = 1; }
    public void _________11_8() { respuestas[10, 7] = 1; }
    public void _________11_9() { respuestas[10, 8] = 1; }
    public void _________11_10() { respuestas[10, 9] = 1; }
    public void _________11_11() { respuestas[10, 10] = 1; }
    public void _________11_12() { respuestas[10, 11] = 1; }

    public void _________12_1() { respuestas[11, 0] = 1; }
    public void _________12_2() { respuestas[11, 1] = 1; }
    public void _________12_3() { respuestas[11, 2] = 1; }
    public void _________12_4() { respuestas[11, 3] = 1; }
    public void _________12_5() { respuestas[11, 4] = 1; }
    public void _________12_6() { respuestas[11, 5] = 1; }
    public void _________12_7() { respuestas[11, 6] = 1; }
    public void _________12_8() { respuestas[11, 7] = 1; }
    public void _________12_9() { respuestas[11, 8] = 1; }
    public void _________12_10() { respuestas[11, 9] = 1; }
    public void _________12_11() { respuestas[11, 10] = 1; }
    public void _________12_12() { respuestas[11, 11] = 1; }

    public void ________13_1() { respuestas[12, 0] = 1; }
    public void ________13_2() { respuestas[12, 1] = 1; }
    public void ________13_3() { respuestas[12, 2] = 1; }
    public void ________13_4() { respuestas[12, 3] = 1; }
    public void ________13_5() { respuestas[12, 4] = 1; }
    public void ________13_6() { respuestas[12, 5] = 1; }
    public void ________13_7() { respuestas[12, 6] = 1; }
    public void ________13_8() { respuestas[12, 7] = 1; }
    public void ________13_9() { respuestas[12, 8] = 1; }
    public void ________13_10() { respuestas[12, 9] = 1; }
    public void ________13_11() { respuestas[12, 10] = 1; }
    public void ________13_12() { respuestas[12, 11] = 1; }


    #endregion
}