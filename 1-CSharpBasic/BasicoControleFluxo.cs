
// 'if/Elseif/Else'; '?/:'; switch; for; while; do/while; try/catch

using System;
using UnityEngine;

public class BasicoControleFluxo : MonoBehaviour
{
    private int vida = 1;
    private int energia = 10;
    private string ArmaAtual = "Espada";
    void Start()
    {
        //if/else if/else
        if (vida >= 1)
        {
            Debug.Log("Ainda está vivo");
        }
        else if (vida == 0)
        {
            Debug.Log("Morto");
        }
        else
        {
            Debug.Log("Valor inválido");
        }
        //IF/ELSE com  ? e : 
        string status = (vida > 100) ? "GodState" : "LessThanGod";
        //switch
        switch (ArmaAtual)
        {
            case "Espada":
                Debug.Log("Você escolheu a espada.");
                break;
            case "Arco":
                Debug.Log("Você escolheu o arco.");
                break;
            default:
                Debug.Log("Arma desconhecida.");
                break;
        }
        //for
        if (energia <= 0) return;

        for (int j = 0; j < 10; j++)
        {
            if (j == 5) continue;
            if (j == 8) break;
            Debug.Log(j);
        }
        //while
        int contador = 0;

        while (contador < 5)
        {
            Debug.Log("Valor de contador: " + contador);
            contador++;
        }
        //foreach
        string[] monstros = { "Golem", "Porteiro", "MadBarkCerberos" };

        foreach (string fruta in monstros)
        {
            Debug.Log("Monstro: " + String.Join(", ", monstros));
        }
        //do while
        int i = 0;
        do
        {
            Debug.Log("Executa ao menos uma vez");
            i++;
        } while (i < 5);
        //try/catch
        try
        {
            int VidaTentativa = 10;
            int resultado = VidaTentativa / 0;
            Debug.Log("Resultado: " + resultado);
        }
        catch (DivideByZeroException)
        {
            Debug.Log("Você não pode fazer isso. (try/catch)");
        }
        finally
        {
            Debug.Log("Este bloco sempre será executado, mesmo com erro.");
        }
        Debug.Log("Código continua normalmente após o try/catch.");
    }

}
