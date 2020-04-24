using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerBehaviour movenemnt;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            FindObjectOfType<AudioManager>().Play("PlayerHitObstacle");

            movenemnt.enabled = false;

            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
