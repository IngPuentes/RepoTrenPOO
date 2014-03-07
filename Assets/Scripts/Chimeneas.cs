using UnityEngine;
using System.Collections;

public class Chimeneas : MonoBehaviour {

	// Use this for initialization
public void crearchimeneas(){

		GameObject chi1 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		chi1.transform.position = new Vector3 (-0.8002372f, 0.2794455f,0.03414962f);
		chi1.transform.localScale = new Vector3 (0.45f, 0.5f, 0.45f);
		chi1.transform.rotation = Quaternion.Euler (0, 0, 0);
		
		GameObject chi2 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		chi2.transform.position = new Vector3 (-0.143906f, 0.2794455f,0.03414962f);
		chi2.transform.localScale = new Vector3 (0.45f, 0.5f, 0.45f);
		chi2.transform.rotation = Quaternion.Euler (0, 0, 0);
		
		GameObject chi3 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		chi3.transform.position = new Vector3 (0.638046f, 0.5440108f,0.03414962f);
		chi3.transform.localScale = new Vector3 (0.45f, 0.5f, 0.45f);
		chi3.transform.rotation = Quaternion.Euler (0, 0, 0);

		}
}
