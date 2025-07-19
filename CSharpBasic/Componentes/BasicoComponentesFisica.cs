// ----------------------######################## VERSÃO 2D CORRIGIDA ######################### --------------------------

// Neste arquivo vamos aprender: uso de Rigidbody2D, Collider2D e interação com o sistema de física 2D da Unity.

using UnityEngine;

// MUDANÇA 1: O atributo agora exige um componente Rigidbody2D.
// Isso garante que qualquer GameObject com este script tenha o componente de física 2D correto.
[RequireComponent(typeof(Rigidbody2D))]
public class BasicoComponentesFisica : MonoBehaviour
{
    // MUDANÇA 2: A variável agora é do tipo Rigidbody2D.
    private Rigidbody2D rb;

    void Start()
    {
        // MUDANÇA 3: O GetComponent agora procura pelo componente Rigidbody2D.
        rb = GetComponent<Rigidbody2D>();

        // MUDANÇA 4: Usamos Vector2.up e ForceMode2D.Impulse.
        // A física 2D tem seus próprios tipos de ForceMode (ForceMode2D).
        rb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
    }

    // MUDANÇA 5: O método de colisão 2D tem "2D" no nome.
    // O parâmetro também muda de "Collision" para "Collision2D".
    void OnCollisionEnter2D(Collision2D colisao)
    {
        Debug.Log("Colidiu com: " + colisao.gameObject.name);
    }

    // O Update continua igual, pois o Input não muda entre 2D e 3D.
    void Update()
    {
        // ... (Este método pode ser removido se vazio)
    }

    // MUDANÇA 6: É uma boa prática mover a lógica de física do Update para o FixedUpdate.
    void FixedUpdate()
    {
        // Move com as setas
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        // MUDANÇA 7: O vetor de movimento agora é um Vector2 (x, y).
        // Em um jogo 2D padrão, o eixo vertical é o Y.
        Vector2 movimento = new Vector2(moveH, moveV);

        // O método AddForce do Rigidbody2D espera um Vector2.
        rb.AddForce(movimento * 10f);
    }
}