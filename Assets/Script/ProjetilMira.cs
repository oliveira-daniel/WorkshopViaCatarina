using UnityEngine;
using System.Collections;

public class ProjetilMira : Projetil
{

	Transform jogador;
	Vector2 direcao;
	
	// Inicializar os componentes e variaveis
	// Determinar o jogador a ser seguido
	public override void Inicializar ()
	{
		base.Inicializar();

		// Saber quem seguir
		jogador = GameObject.FindGameObjectWithTag ("Player").transform;
		direcao = jogador.transform.position - transform.position;
		direcao.Normalize ();
	}

	// Mover na direçao do jogador
	public override void Mover ()
	{
		rb.velocity = direcao * velocidade;
	}

}
