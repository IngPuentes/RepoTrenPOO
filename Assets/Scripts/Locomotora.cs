using UnityEngine;
using System.Collections;

public class Locomotora : MonoBehaviour {

	// Use this for initialization
	public void crearLocomotora(){
		GameObject locomotora = GameObject.CreatePrimitive(PrimitiveType.Cube);
		locomotora.transform.position = new Vector3(-0.3693028f, -0.609012F, 0);
		locomotora.transform.localScale = new Vector3 (3.818915f,0.2284507f,1.174954f);
		locomotora.transform.rotation = Quaternion.Euler (0,0,0);

		GameObject base1 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		base1.transform.position = new Vector3 (0, 0,0);
		base1.transform.localScale = new Vector3 (1, 1.227798f, 1);
		base1.transform.rotation = Quaternion.Euler (0, 0, 90);
	}
	                           
}
