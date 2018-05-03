using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarControllerActive : MonoBehaviour {

    public GameObject CarControl;

	// Use this for initialization
	void Start () {
        CarControl.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;
	}
	
	
}
