using UnityEngine;
using System.Collections;

public class Ruedas : MonoBehaviour {

	// Use this for initialization
	public void crearruedas(){
		GameObject llanta1 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		llanta1.transform.position = new Vector3 (0.0425142f, -0.601666f,0.8099231f);
		llanta1.transform.localScale = new Vector3 (1, 0.08905098f, 1);
		llanta1.transform.rotation = Quaternion.Euler (90, 0, 0);
		
		GameObject llanta2 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		llanta2.transform.position = new Vector3 (-2.196774f, -0.6016659f,-0.7878922f);
		llanta2.transform.localScale = new Vector3 (1, 0.08905098f, 1);
		llanta2.transform.rotation = Quaternion.Euler (90, 0, 0);
		
		GameObject llanta3 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		llanta3.transform.position = new Vector3 (-1.075756f, -0.601666f,0.8099231f);
		llanta3.transform.localScale = new Vector3 (1.13665f, 0.08905098f, 1.13665f);
		llanta3.transform.rotation = Quaternion.Euler (90, 0, 0);
		
		GameObject llanta4 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		llanta4.transform.position = new Vector3 (-2.223586f, -0.601666f,0.8099231f);
		llanta4.transform.localScale = new Vector3 (1, 0.08905098f, 1);
		llanta4.transform.rotation = Quaternion.Euler (90, 0, 0);

		GameObject llanta5 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		llanta5.transform.position = new Vector3 (0.0425142f, -0.6016659f,-0.8041588f);
		llanta5.transform.localScale = new Vector3 (1, 0.08905098f, 1);
		llanta5.transform.rotation = Quaternion.Euler (90, 0, 0);

		GameObject llanta6 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		llanta6.transform.position = new Vector3 (-1.062676f, -0.6016659f,-0.7924734f);
		llanta6.transform.localScale = new Vector3 (1, 0.08905098f, 1);
		llanta6.transform.rotation = Quaternion.Euler (90, 0, 0);
	}
}
