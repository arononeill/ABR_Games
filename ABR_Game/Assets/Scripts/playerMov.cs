using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMov : MonoBehaviour {

    public Rigidbody rb;

	public int points = 0;
	public int mushies;
	public static int highscore = 0;
    public float speed = 2000f;
    public float sideways = 500f;
	public Texture btnTexture;
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);

        if ( Input.GetKey("right"))
        {
            rb.AddForce(sideways * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("left"))
        {
            rb.AddForce(-sideways *Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
		highscore = points;
    }

	private void OnGUI() {
		GUI.Label (new Rect (10, 30, 100, 20), "Coins : " + points);
		GUI.Label (new Rect (10, 10, 100, 20), "Mushies : " + mushies);

		if (GUI.Button (new Rect (1280, 10, 80, 30), "Main Menu")) {
			Debug.Log ("Returned To The MainMenu");
			SceneManager.LoadScene (0);
		}

	}
}