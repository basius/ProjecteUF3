using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {
    public bool iniciarEnMovimiento = false;
	public float velocidad = 0f;
	private bool enMovimiento = false;
	private float tiempoInicio = 0f;
    public Renderer rend;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>(); rend.enabled = true;
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeEmpiezaACorrer");
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
        if (iniciarEnMovimiento)
        {
            PersonajeEmpiezaACorrer();
        }
	}

	void PersonajeHaMuerto(){
		enMovimiento = false;
	}

	void PersonajeEmpiezaACorrer(){
		enMovimiento = true;
		tiempoInicio = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(enMovimiento){
			rend.material.mainTextureOffset = new Vector2(((Time.time - tiempoInicio) * velocidad) % 1, 0);
        }
	}
}
