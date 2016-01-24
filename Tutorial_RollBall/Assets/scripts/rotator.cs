using UnityEngine;
using System.Collections;

public class rotator : MonoBehaviour {

	// Update is called once per frame
	void Update () 
	{
		//.Rotate(x, y, z) applies a rotation around that point 
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}
