using UnityEngine;
using UnityEngine.UI;
using System;

public class EarthScore : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public static int high = 0;
    public int EScore;

    public void Reset()
    {
        PlayerPrefs.DeleteKey("EarthHighScore");
    }

    void Start()
    {
        EScore = PlayerPrefs.GetInt("EarthHighScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        score();
    }

    void score()
    {
        high = playerMov.highscore;
        double pos = (player.position.z + 50.92989) * high;
        scoreText.text = pos.ToString("0");
        int value = Convert.ToInt32(pos);
        if (value > PlayerPrefs.GetInt("EarthHighScore", 0))
        {
            PlayerPrefs.SetInt("EarthHighScore", value);
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 50, 100, 20), "Highscore : " + EScore);
    }
}
