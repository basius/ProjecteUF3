using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualizarValoresGameOver : MonoBehaviour {
    public TextMesh total;
    public Puntuacion puntuacion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnEnable()
    {
        total.text = "TOTAL: "+puntuacion.puntuacion.ToString();
    }
}
