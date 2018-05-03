using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	void Update() {
		transform.Rotate (90 * Time.deltaTime, 0, 0);
	}

	private void OnTriggerEnter (Collider other) {
		if (other.name == "Car") {

			FindObjectOfType<AudioManager> ().Play ("CoinPickup");

			other.GetComponent<playerMov>().points++;
			Destroy (gameObject);
		}
	}

}
