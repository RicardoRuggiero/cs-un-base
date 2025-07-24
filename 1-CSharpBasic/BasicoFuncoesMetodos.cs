
// Declara��o de m�todos, chamadas, par�metros, retorno de valor e sobrecarga b�sica.

using UnityEngine;

public class BasicoFuncoesMetodos : MonoBehaviour
{
    void Start()
    {
        // Chamando m�todos
        MostrarMensagemSimples();
        MostrarMensagemComTexto("Bem-vindo(a) ao jogo!");
        int dobro = CalcularDobro(10);
        Debug.Log("Dobro de 10 �: " + dobro);

        int resultadoSoma = Somar(5, 7);
        Debug.Log("Soma: " + resultadoSoma);
    }

    // M�todo simples sem par�metros e sem retorno
    void MostrarMensagemSimples()
    {
        Debug.Log("Ol�, esta � uma fun��o simples!");
    }

    // M�todo com par�metro
    void MostrarMensagemComTexto(string mensagem)
    {
        Debug.Log("Mensagem recebida: " + mensagem);
    }

    // M�todo com retorno
    int CalcularDobro(int numero)
    {
        return numero * 2;
    }

    // M�todo com m�ltiplos par�metros e retorno
    int Somar(int a, int b)
    {
        return a + b;
    }

    void Update()
    {

    }
}
