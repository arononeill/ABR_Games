using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public static ScoreText instance = null;

    // Use this for initialization
    public GameObject CoinsCollectedObject;

    int score = 0;
    Text CoinsCollected;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "coin")
        {
            score += 5;
        }
    }
   

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            Destroy(gameObject);
        }

        //Displaying our score integer to a string
        CoinsCollected.text = "Coins:" + score.ToString();

    }

    void Start()
    {
        CoinsCollected = GetComponent<Text>();
    }

    public void Collect( int passedValue, GameObject passedObject)
    {
        passedObject.GetComponent<Renderer>().enabled = false;
        score = score + passedValue;
        CoinsCollected.text = "Coins:" + score.ToString();
    }


}
