// ----------------------######################## VERS�O 2D CORRIGIDA ######################### --------------------------

// Neste arquivo vamos aprender: uso de Rigidbody2D, Collider2D e intera��o com o sistema de f�sica 2D da Unity.

using UnityEngine;

// MUDAN�A 1: O atributo agora exige um componente Rigidbody2D.
// Isso garante que qualquer GameObject com este script tenha o componente de f�sica 2D correto.
[RequireComponent(typeof(Rigidbody2D))]
public class BasicoComponentesFisica : MonoBehaviour
{
    // MUDAN�A 2: A vari�vel agora � do tipo Rigidbody2D.
    private Rigidbody2D rb;

    void Start()
    {
        // MUDAN�A 3: O GetComponent agora procura pelo componente Rigidbody2D.
        rb = GetComponent<Rigidbody2D>();

        // MUDAN�A 4: Usamos Vector2.up e ForceMode2D.Impulse.
        // A f�sica 2D tem seus pr�prios tipos de ForceMode (ForceMode2D).
        rb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
    }

    // MUDAN�A 5: O m�todo de colis�o 2D tem "2D" no nome.
    // O par�metro tamb�m muda de "Collision" para "Collision2D".
    void OnCollisionEnter2D(Collision2D colisao)
    {
        Debug.Log("Colidiu com: " + colisao.gameObject.name);
    }

    // O Update continua igual, pois o Input n�o muda entre 2D e 3D.
    void Update()
    {
        // ... (Este m�todo pode ser removido se vazio)
    }

    // MUDAN�A 6: � uma boa pr�tica mover a l�gica de f�sica do Update para o FixedUpdate.
    void FixedUpdate()
    {
        // Move com as setas
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        // MUDAN�A 7: O vetor de movimento agora � um Vector2 (x, y).
        // Em um jogo 2D padr�o, o eixo vertical � o Y.
        Vector2 movimento = new Vector2(moveH, moveV);

        // O m�todo AddForce do Rigidbody2D espera um Vector2.
        rb.AddForce(movimento * 10f);
    }
}