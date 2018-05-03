using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public int mushies;

	public void PlayLevel01 () {
		SceneManager.LoadScene (1);
	}

	public void PlayMarsScene () {
		SceneManager.LoadScene (2);
	}

	public void PlayMoonScene () {
		SceneManager.LoadScene (3);
	}

	public void PlayJupiterScene () {
		SceneManager.LoadScene (4);
	}

    private void OnGUI() {
		GUI.Label (new Rect (10, 10, 100, 20), "Mushies : " + mushies);
	}

}
