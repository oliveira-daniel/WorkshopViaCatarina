using UnityEngine;
using System.Collections;

public class Projetil : MonoBehaviour
{

	// Funçoes fisicas da Unity
	protected Rigidbody2D rb;

	// Velocidade de movimentaçao
	public float velocidade;

	// Dano causado ao acertar
	public int dano;

	// Tag para atingir o inimigo
	public string TagInimigo { private get; set; }

	// Use this for initialization
	void Start ()
	{
		Inicializar();
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		// Usar fisicas p/ movimentaçao
		// Movimentar sempre pra cima

		// Melhorar atraves de metodos
		Mover ();
	}

	// Inicializar os componentes e variaveis
	public virtual void Inicializar ()
	{
		rb = GetComponent<Rigidbody2D> ();
		Destroy (gameObject, 2f);
	}

	public virtual void Mover ()
	{
		rb.velocity = Vector2.up * velocidade;
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		// Verificar a colisao com o inimigo ou com o jogador
		if (col.transform.tag == TagInimigo) {
			Destroy (gameObject);
			Personagem p = col.GetComponent<Personagem> ();
			p.ReceberDano (dano);
		}
	}
}
