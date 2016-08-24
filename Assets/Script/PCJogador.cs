using UnityEngine;
using System.Collections;

public class PCJogador : Personagem
{

	// Aplicar a movimentaçao do personagem
	public override void Movimentar ()
	{

		// Usar fisicas p/ movimentaçao
		// Usando as entradas do teclado
		rb.velocity = new Vector2 (
			Input.GetAxis ("Horizontal") * velocidade, 
			Input.GetAxis ("Vertical") * velocidade
		);

	}

	void Update ()
	{
		// Quando apertar a tecla 'x'
		if (Input.GetButtonDown ("Jump")) {
			Atirar ("Inimigo");
		}
	}

	// Power-ups
}
