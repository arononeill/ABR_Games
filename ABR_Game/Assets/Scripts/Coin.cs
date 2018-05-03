using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    public bool coinMag = false;
    public float magLength = 0.0f;

	void Update() {
		transform.Rotate (90 * Time.deltaTime, 0, 0);

        if (coinMag == true)
        {
            magLength += 1 * Time.deltaTime;
            if (magLength > 5.5)
            {
                coinMag = false;
                magLength = 0;
            }
        }

        GameObject Coin = GameObject.FindGameObjectWithTag("Coin");
        GameObject M = GameObject.FindGameObjectWithTag("magnetic");
        GameObject P = GameObject.FindGameObjectWithTag("Player");

        if (coinMag == true)
        {
            if (Vector3.Distance(transform.position, P.transform.position) < 55)
            {
                transform.Translate((P.transform.position - transform.position).normalized * 65 * Time.deltaTime, Space.World);
            }
        }

        if (M != null)
        {
            if (Vector3.Distance(M.transform.position, P.transform.position) < 3)
            {
                Destroy(GameObject.FindWithTag("magnetic"));

                if (coinMag == false)
                {
                    coinMag = true;
                }

            }
        }
	}

	private void OnTriggerEnter (Collider other) {
        if (other.name == "Player" | other.name == "Micro_Sub" | other.name == "Colliders") {
            FindObjectOfType<AudioManager> ().Play ("CoinPickup");
            other.GetComponent<playerMov>().points++;
			Destroy (gameObject);
		}
	}

}
