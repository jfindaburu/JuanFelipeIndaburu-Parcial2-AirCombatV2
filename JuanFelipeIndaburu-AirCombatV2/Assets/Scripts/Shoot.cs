using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// mover el avion

		if (Input.GetKey(KeyCode.UpArrow)) {
			this.transform.Translate (0.0f, 2.0f, 0.0f);
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			this.transform.Translate (0.0f, -2.0f, 0.0f);
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			this.transform.Translate (2.0f, 0.0f, 0.0f);
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			this.transform.Translate (-2.0f, 0.0f, 0.0f);
		}
		// avion avanza hacia adelante

		{
			transform.Translate(Vector3.forward * Time.deltaTime*10);
		}

			

		// si el usuario presiona la tecla espacio
		if (Input.GetKeyDown (KeyCode.Space)) {
			// Creo un game object a partit de la informacion giardada
			// en un prefab
			GameObject missile = GameObject.Instantiate (Resources.Load ("Prefabs/Missile") as GameObject);

			//hago que else misil sea hijo del avion 
			missile.transform.SetParent(this.transform);

			//Muevo el misil a la posicion 
			missile.transform.localPosition= new Vector3 (180.0f,-20.0f,0.0f);

		// saco al misil del avion 
			missile.transform.SetParent(null);

		




		}

	}
}
