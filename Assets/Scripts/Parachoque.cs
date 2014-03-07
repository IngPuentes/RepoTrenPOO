using UnityEngine;
using System.Collections;

public class Parachoque : MonoBehaviour {

	// Use this for initialization
public void crearparachoque(){
		GameObject antichoqueA = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		antichoqueA.transform.position = new Vector3(1.589902f, -0.6020046F, 0.343542f);
		antichoqueA.transform.localScale = new Vector3 (0.15f,0.2f,0.15f);
		antichoqueA.transform.rotation = Quaternion.Euler (0,0,90);

		GameObject antichoqueB = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		antichoqueB.transform.position = new Vector3(1.589902f, -0.6020046F, -0.3054736f);
		antichoqueB.transform.localScale = new Vector3 (0.15f,0.2f,0.15f);
		antichoqueB.transform.rotation = Quaternion.Euler (0,0,90);

		GameObject antichoqueC = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		antichoqueC.transform.position = new Vector3(1.076712f, -0.6142823F, 0.78335f);
		antichoqueC.transform.localScale = new Vector3 (0.4f,0.4610712f,0.4f);
		antichoqueC.transform.rotation = Quaternion.Euler (0,0,90);

		GameObject antichoqueD = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		antichoqueD.transform.position = new Vector3(1.076712f, -0.6142823F, -0.7886727f);
		antichoqueD.transform.localScale = new Vector3 (0.4f,0.4610712f,0.4f);
		antichoqueD.transform.rotation = Quaternion.Euler (0,0,90);

		GameObject antichoqueE = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		antichoqueE.transform.position = new Vector3(1.742181f, -0.6020046F, -0.3054736f);
		antichoqueE.transform.localScale = new Vector3 (0.3f,0.05125147f,0.3f);
		antichoqueE.transform.rotation = Quaternion.Euler (0,0,90);

		GameObject antichoqueF = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		antichoqueF.transform.position = new Vector3(1.742181f, -0.6020046F, 0.3460204f);
		antichoqueF.transform.localScale = new Vector3 (0.3f,0.05125147f,0.3f);
		antichoqueF.transform.rotation = Quaternion.Euler (0,0,90);

		}
}
