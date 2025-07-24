
// Declaração de métodos, chamadas, parâmetros, retorno de valor e sobrecarga básica.

using UnityEngine;

public class BasicoFuncoesMetodos : MonoBehaviour
{
    void Start()
    {
        // Chamando métodos
        MostrarMensagemSimples();
        MostrarMensagemComTexto("Bem-vindo(a) ao jogo!");
        int dobro = CalcularDobro(10);
        Debug.Log("Dobro de 10 é: " + dobro);

        int resultadoSoma = Somar(5, 7);
        Debug.Log("Soma: " + resultadoSoma);
    }

    // Método simples sem parâmetros e sem retorno
    void MostrarMensagemSimples()
    {
        Debug.Log("Olá, esta é uma função simples!");
    }

    // Método com parâmetro
    void MostrarMensagemComTexto(string mensagem)
    {
        Debug.Log("Mensagem recebida: " + mensagem);
    }

    // Método com retorno
    int CalcularDobro(int numero)
    {
        return numero * 2;
    }

    // Método com múltiplos parâmetros e retorno
    int Somar(int a, int b)
    {
        return a + b;
    }

    void Update()
    {

    }
}
