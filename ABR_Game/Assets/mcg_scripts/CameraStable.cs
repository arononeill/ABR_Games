using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour {

    public GameObject TheCar;
    public float CarX;
    public float CarY;
    public float CarZ;


    // Update is called once per frame
    void Update () {

        CarX = TheCar.transform.eulerAngles.x;
        CarY = TheCar.transform.eulerAngles.y;
        CarZ = TheCar.transform.eulerAngles.z;

        // Makes the camera rotate a different way to car when turning
        // carX - carX allows the cameral to rotate in opposite direction.
        transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);
	}
}
