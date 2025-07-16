using NUnit.Framework.Internal;
using Unity.VisualScripting;
using UnityEngine;

public class BasicoLista : MonoBehaviour
{
    private string[] GrupoDeJogadores = 
    { 
        "Ying", "Yang", "Shadow", "Blower", "Smoox", "Hashashin", "S�String", "N4daM41s" , "Erbrios"
    };
    void Start()
    {
        Debug.Log("primeiro" + GrupoDeJogadores[0]);
        Debug.Log("segundo " + GrupoDeJogadores[1]);
        Debug.Log("Existe " + GrupoDeJogadores.Length + " jogadores");
        Debug.Log("O primeiro era " + GrupoDeJogadores[0] + " e n�o " + GrupoDeJogadores[7]);

        bool ExisteJogadorEm = true;
        bool ExisteOitoJogadoresEm = false;

        if (ExisteJogadorEm == true)
        {
            Debug.Log("A prova de que existe " + GrupoDeJogadores);
        }
        else if (ExisteJogadorEm == true && ExisteOitoJogadoresEm == true)
        {
            Debug.Log("Oitavo, " + GrupoDeJogadores[8] + " est� vendo voc�");
        }
        else
        {
            Debug.Log("'apenas', " + GrupoDeJogadores[6]);
        }

        /*
         Nome do Treino: Cria��o e Popula��o de Lista

        Palavra Fundamental: Add

        Nome do Treino: Acesso e Modifica��o por Posi��o

        Palavra Fundamental: �ndice

        Nome do Treino: Busca e Exclus�o de Elementos

        Palavra Fundamental: Remove

        Nome do Treino: Itera��o e Sele��o com L�gica

        Palavra Fundamental: Filtro

        Nome do Treino: Manipula��o Din�mica de Tamanho

        Palavra Fundamental: Din�mica
         */

    }

    void Update()
    {
        
    }
}
