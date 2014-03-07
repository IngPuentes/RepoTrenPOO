using UnityEngine;
using System.Collections;

public class Cabina : MonoBehaviour {

	// Use this for initialization
	public void crearcabina(){
		GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube1.transform.position = new Vector3(-1.72615f, 0.1614037F, 0);
		cube1.transform.localScale = new Vector3 (1.086986f,1.733263f,1.174954f);
		cube1.transform.rotation = Quaternion.Euler (0,0,0);
		
		GameObject cube2 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube2.transform.position = new Vector3(-1.729017f, 0.9536775F, 0.4516523f);
		cube2.transform.localScale = new Vector3 (1.086986f,0.2355465f,1);
		cube2.transform.rotation = Quaternion.Euler (12.83092f,0,0);
		
		GameObject cube3 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube3.transform.position = new Vector3(-1.729017f, 0.9608097F, -0.4642213f);
		cube3.transform.localScale = new Vector3 (1.086986f,0.2355465f,1);
		cube3.transform.rotation = Quaternion.Euler (348.6373f,0,0);

		GameObject ventana1 = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		ventana1.transform.position = new Vector3(-1.729017f, 0.5422351F, -0.4642213f);
		ventana1.transform.localScale = new Vector3 (0.5f,0.5f,0.5f);
		ventana1.transform.rotation = Quaternion.Euler (0,0,0);

		GameObject ventana2 = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		ventana2.transform.position = new Vector3(-1.724297f, 0.5422351F, 0.4703345f);
		ventana2.transform.localScale = new Vector3 (0.5f,0.5f,0.5f);
		ventana2.transform.rotation = Quaternion.Euler (0,0,0);
		

		}
}
