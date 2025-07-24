
// int, float, bool, string

using UnityEngine;

public class BasicoVariaveis : MonoBehaviour
{
    internal static int VarIntEstatico = 0;
    protected static string VarStrEstatica = "Você Começa agora: !#@ 1";

    public int MeuNumeroInteiro = 321;
    public float MeuNumeroQuebrado = 42.0f;

    private int MeuNumeroInteiro2 = 678;
    private float MeuNumeroQuebrado2 = 9.01f;

    public string VariavelTexto = "ok";
    private string VariavelTexto2 = string.Empty;

    public bool SeraLogico = false;
    private bool SeraLogico2 = true;

    void Start()
    {
        Debug.Log(VarIntEstatico);
        Debug.Log(VarStrEstatica);

        Debug.Log("ptbr-Mensagem Primal: O Jogo foi Inciado. en-Network setup started. fr-Message Principal. !#@");
        MeuNumeroInteiro = 123;
        MeuNumeroQuebrado = 4.5f;

        Debug.Log(MeuNumeroInteiro);
        Debug.Log(MeuNumeroQuebrado);
        
        Debug.Log(MeuNumeroInteiro2);
        Debug.Log(MeuNumeroQuebrado2);

        int VidaMenu = 888;
        Debug.Log(VidaMenu);

        Debug.Log(VariavelTexto);
        Debug.Log(VariavelTexto + VariavelTexto2 + VariavelTexto);

        Debug.Log(SeraLogico);
        Debug.Log(SeraLogico2);
    }

    void Update()
    {
        
    }
}
