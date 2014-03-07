using UnityEngine;
using System.Collections;

public class Tren : MonoBehaviour {

	// Use this for initialization
	public void crearTren(){
		Cabina cab = new Cabina ();
		Ruedas rue = new Ruedas ();
		Parachoque spo = new Parachoque ();
		Chimeneas chi = new Chimeneas ();
		Locomotora loc = new Locomotora ();

		cab.crearcabina ();
		rue.crearruedas ();
		spo.crearparachoque ();
		chi.crearchimeneas ();
		loc.crearLocomotora ();


	}

}
