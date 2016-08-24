using UnityEngine;
using System.Collections;

public class Personagem : MonoBehaviour
{

	// Funçoes fisicas da Unity
	protected Rigidbody2D rb;

	// Velocidade de movimentaçao
	public float velocidade;

	// Pontos de vida do personagem
	public int ptosVida;

	// Sprite do disparo
	public GameObject projetil;

	// ---
	[SerializeField]
	protected Transform posIniProjetil;

	// Use this for initialization
	void Start ()
	{
	
		rb = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{

		Movimentar ();
	
	}

	// Funçao de movimento do personagem
	public virtual void Movimentar ()
	{
	}

	// Atirar
	// ---
	public virtual void Atirar (string tag)
	{
		GameObject g = Instantiate (projetil, posIniProjetil.position, Quaternion.identity) as GameObject;
		g.GetComponent<Projetil> ().TagInimigo = tag;
	}

	// Receber dano
	public void ReceberDano (int qtdDano)
	{
		ptosVida -= qtdDano;

		// Verificar a morte
		if (ptosVida <= 0) {
			SerEliminado ();
		}
	}

	// Eliminado
	public virtual void SerEliminado ()
	{
		// Objeto desaparece
		Destroy (gameObject);
	}
}
