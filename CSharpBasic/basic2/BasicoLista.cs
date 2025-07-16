using NUnit.Framework.Internal;
using Unity.VisualScripting;
using UnityEngine;

public class BasicoLista : MonoBehaviour
{
    private string[] GrupoDeJogadores = 
    { 
        "Ying", "Yang", "Shadow", "Blower", "Smoox", "Hashashin", "SóString", "N4daM41s" , "Erbrios"
    };
    void Start()
    {
        Debug.Log("primeiro" + GrupoDeJogadores[0]);
        Debug.Log("segundo " + GrupoDeJogadores[1]);
        Debug.Log("Existe " + GrupoDeJogadores.Length + " jogadores");
        Debug.Log("O primeiro era " + GrupoDeJogadores[0] + " e não " + GrupoDeJogadores[7]);

        bool ExisteJogadorEm = true;
        bool ExisteOitoJogadoresEm = false;

        if (ExisteJogadorEm == true)
        {
            Debug.Log("A prova de que existe " + GrupoDeJogadores);
        }
        else if (ExisteJogadorEm == true && ExisteOitoJogadoresEm == true)
        {
            Debug.Log("Oitavo, " + GrupoDeJogadores[8] + " está vendo você");
        }
        else
        {
            Debug.Log("'apenas', " + GrupoDeJogadores[6]);
        }

        /*
         Nome do Treino: Criação e População de Lista

        Palavra Fundamental: Add

        Nome do Treino: Acesso e Modificação por Posição

        Palavra Fundamental: Índice

        Nome do Treino: Busca e Exclusão de Elementos

        Palavra Fundamental: Remove

        Nome do Treino: Iteração e Seleção com Lógica

        Palavra Fundamental: Filtro

        Nome do Treino: Manipulação Dinâmica de Tamanho

        Palavra Fundamental: Dinâmica
         */

    }

    void Update()
    {
        
    }
}
