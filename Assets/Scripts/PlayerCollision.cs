using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerBehaviour movenemnt;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            // Play hit wall sound
            FindObjectOfType<AudioManager>().Play("PlayerHitObstacle");

            // Disable player movement
            movenemnt.enabled = false;

            // Restart game call method
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
