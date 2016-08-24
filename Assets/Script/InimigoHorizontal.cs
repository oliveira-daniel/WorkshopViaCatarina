using UnityEngine;
using System.Collections;

public class InimigoHorizontal : Personagem
{

	private float tempoDisparo;
	public float tempoMaxDisparo = 2f;

	// Movimentar o inimmigo no sentido horizontal,
	// direita / esquerda e vice-versa.
	public override void Movimentar ()
	{

	}

	void Update ()
	{

		// Contar o tempo de disparo
		tempoDisparo += Time.deltaTime;

		if (tempoDisparo >= tempoMaxDisparo) {
			tempoDisparo = 0;
			Atirar ("Player");
		}

	}

}
