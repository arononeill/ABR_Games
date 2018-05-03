using UnityEngine;

public class EndTrigger1 : MonoBehaviour
{

    public GameManager gameManager1;

    void OnTriggerEnter()
    {
        gameManager1.CompletedLevel();
    }
}