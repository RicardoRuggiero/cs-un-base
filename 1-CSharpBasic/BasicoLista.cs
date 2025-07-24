
// listas em c# na unity

using NUnit.Framework.Internal;
using System.Collections.Generic; //Para listas funcionar
//using System.Diagnostics; //Gerou conflito
using Unity.VisualScripting;
using UnityEngine;

public class BasicoLista : MonoBehaviour
{
    private string NomePlayer1 = "AERBRIOS";
    private string NomePlayer2 = "ZUERINHO";
    private string NomePlayer3 = "AZEUREBRRIINOHOS";
    private string NomePlayer4 = "OSHONIIRRBERUEZA";
    private string[] GrupoDeJogadores = 
    { 
        "Ying", "Yang", "Shadow", "Blower", "Smoox", "Hashashin", "S�String", "8Avo" , "Erbrios"
    };
    private List<string> GrupoJogadores = new List<string>();
    private List<int> GrupoEscolas = new List<int>();
    private List<float> GrupoValores = new List<float>() { 1.5f,5f, 9.0f};
    private List<bool> MortoVivo = new List<bool>() {true, false, true, true, true};
    private List<char> NotaJogadores = new List<char> {'X', 'S', 'A', 'B', 'C', 'D', 'E', 'F', 'O', 'U', 'K', 'Z'};
    //private List<GameObject> GrupoMonstros = new List<GameObject>(); //GameObject
    //private List<Transform> WarpTo = new List<Transform>(); //Um objeto com posi��o, rota��o, escala e hierarquia
    //private List<Vector3> posicoes = new List<Vector3>(); //Um valor de posi��o, velocidade, for�a, dire��o, etc.
    //private List<Color> cores = new List<Color> { Color.red, Color.green, Color.blue}; //PARA HEXADECIMAL
    //PARA HEXADECIMAL: precisa estar antes da lista ou marcado como static, j� que est� sendo usado na inicializa��o.
    //List<InimigoP> InimigoPassivo = new List<InimigoP>();   //precisa de um scrip 'InimigoP'
    //List<InimigoA> InimigoAgressivo = new List<InimigoA>(); //precisa de um scrip 'InimigoA'
    void Start()
    {
        Debug.Log("Teste Nome: " + GrupoDeJogadores[8]);
        Debug.Log("Lista00: " + GrupoDeJogadores[0] + " Lista08: " + GrupoDeJogadores[7]);
        GrupoJogadores.Add("Todos Adicionados: " + NomePlayer1);
        GrupoJogadores.AddRange(new[] { NomePlayer2, NomePlayer3, NomePlayer4 });
        Debug.Log(string.Join(", ", GrupoJogadores));
        GrupoEscolas.AddRange(new[] { 1, 2, 3, 4 });
        GrupoValores[1] = 6.9f;
        MortoVivo[3] = false;
        Debug.Log($" Tr�s numeros de tipo float {string.Join("; ", GrupoValores)}, e o Undead4 esta vivo: {MortoVivo[3]} ");
        Debug.Log($" Escolas Agora S�o: {string.Join(", ", GrupoEscolas)}, disse, {NomePlayer4}");
        Debug.Log($" Ins�gnias: {string.Join(", ", NotaJogadores)}, falou, {NomePlayer3}");
    }
}
