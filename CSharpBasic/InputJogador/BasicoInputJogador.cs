// Nesse arquivo vamos aprender: como capturar input do teclado e usar ações do jogador.

using UnityEngine;

public class BasicoInputJogador : MonoBehaviour
{
    public float velocidade = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 direcao = new Vector3(moveX, 0, moveZ);
        transform.Translate(direcao * velocidade * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Pulou!");
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clique do mouse!");
        }
    }
}
