using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed = 120f;

    // Update is called once per frame
    void Update()
    { 
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("CoinPickup");
            FindObjectOfType<CoinsNumber>().UpdateCoinText();
            
            Destroy(gameObject);
        }
    }
}
