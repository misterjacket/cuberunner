using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed = 120f;

    public GameObject pickedupEffect;

    // Update is called once per frame
    void Update()
    { 
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            Pickup();
    }
    
    void Pickup()
    {
        // Spawn a cool effect
        Instantiate(pickedupEffect, transform.position, transform.rotation);

        FindObjectOfType<AudioManager>().Play("CoinPickup");
        FindObjectOfType<CoinsNumber>().UpdateCoinText();

        // Destroy the picked up Coin
        Destroy(gameObject);    
    }
}
