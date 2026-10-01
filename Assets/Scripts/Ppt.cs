using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ppt : MonoBehaviour
{
    // Cambiado de 'movimientos' a 'jugadas' como querías
    public string[] jugadas = { "roca", "papel", "tijera" };

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            CheckResult("papel");
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            CheckResult("roca");
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            CheckResult("tijera");
        }
    }

    void CheckResult(string jugada)
    {
        
        string jugadabot = jugadas[Random.Range(0, jugadas.Length)];

        Debug.Log("Tú elegiste: " + jugada + " | El Bot eligió: " + jugadabot);

        if (jugada == jugadabot)
        {
            Debug.Log("Resultado: ¡Empate!");
        }
        else if ((jugada == "roca" && jugadabot == "tijera") ||
                 (jugada == "papel" && jugadabot == "roca") ||
                 (jugada == "tijera" && jugadabot == "papel"))
        {
            Debug.Log("Resultado: ¡Ganaste!");
        }
        else
        {
            Debug.Log("Resultado: ¡Perdiste!");
        }
    }
}