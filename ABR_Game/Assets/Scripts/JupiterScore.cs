using UnityEngine;
using UnityEngine.UI;
using System;

public class JupiterScore : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public static int high = 0;
    public int JScore;

    public void Reset()
    {
        PlayerPrefs.DeleteKey("JupiterHighScore");
    }

    void Start()
    {
        JScore = PlayerPrefs.GetInt("JupiterHighScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        score();
    }

    void score()
    {
        high = playerMov.highscore;
        double pos = (player.position.z + 1249) * high;
        pos = pos/ 10;
        scoreText.text = pos.ToString("0");
        int value = Convert.ToInt32(pos);

        if (value > PlayerPrefs.GetInt("JupiterHighScore", 0))
        {
            PlayerPrefs.SetInt("JupiterHighScore", value);
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 50, 100, 20), "Highscore : " + JScore);
    }
}
