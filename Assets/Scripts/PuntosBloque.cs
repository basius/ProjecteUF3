using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntosBloque : MonoBehaviour {

    private bool haColisionadoConElJugador = false;
    public int puntosGanados = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!haColisionadoConElJugador && (collision.collider.gameObject.name == "PataInferiorDerechaB" || collision.collider.gameObject.name == "PataInferiorIzquierdaB"))
        {
            haColisionadoConElJugador = true;
            NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
        }
    }
}
