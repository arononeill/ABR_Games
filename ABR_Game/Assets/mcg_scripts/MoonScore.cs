using UnityEngine;
using UnityEngine.UI;
using System;

public class MoonScore : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public static int high = 0;
    public int MScore;

    public void Reset()
    {
        PlayerPrefs.DeleteKey("MoonHighScore");
    }

    void Start()
    {
        MScore = PlayerPrefs.GetInt("MoonHighScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        score();
    }

    void score()
    {
        high = ScorePrint.highscore;
        double pos = (player.position.z) * high;
        scoreText.text = pos.ToString("0");
        int value = Convert.ToInt32(pos);

        if (value > PlayerPrefs.GetInt("MoonHighScore", 0))
        {
            PlayerPrefs.SetInt("MoonHighScore", value);
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 50, 100, 20), "Highscore : " + MScore);
    }
}
