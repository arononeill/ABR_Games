using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingRock : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(90 * Time.deltaTime -6, 0, 0);
	}
}
