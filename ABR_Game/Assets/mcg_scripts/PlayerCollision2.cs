using UnityEngine;

public class PlayerCollision2 : MonoBehaviour
{

    public ScorePrint movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle" || collisionInfo.collider.tag == "Fence" || collisionInfo.collider.tag == "UFO")
        {
            FindObjectOfType<AudioManager>().Play("Crash");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
