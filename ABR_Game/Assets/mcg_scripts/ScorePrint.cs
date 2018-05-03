using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScorePrint : MonoBehaviour
{ 
    public Rigidbody rb;

    public int points = 0;
    public int mushies;
    public static int highscore = 0;
    public Texture btnTexture;

    // Update is called once per frame
    void FixedUpdate()
    {
        highscore = points;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 30, 100, 20), "Coins : " + points);
        GUI.Label(new Rect(10, 10, 100, 20), "Mushies : " + mushies);

        if (GUI.Button(new Rect(1280, 90, 80, 30), "Main Menu"))
        {
            Debug.Log("Returned To The MainMenu");
            SceneManager.LoadScene(0);
        }

    }
}