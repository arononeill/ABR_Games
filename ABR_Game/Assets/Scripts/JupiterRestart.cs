using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JupiterRestart : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Vector3 pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -22.1)
        {

            FindObjectOfType<GameManager>().EndGame();
        }
    }


}
