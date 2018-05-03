using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushies : MonoBehaviour {

	private void OnTriggerEnter (Collider other) {
		if (other.name == "Player") {
			FindObjectOfType<AudioManager> ().Play ("MushiePickup");
			other.GetComponent<playerMov>().mushies++;
			Destroy (gameObject);
		}
	}
}
