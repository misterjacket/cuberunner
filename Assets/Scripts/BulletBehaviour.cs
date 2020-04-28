using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float speed;
    public float secondsUntilDestroyed;

    private void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        secondsUntilDestroyed -= Time.deltaTime;

        if (secondsUntilDestroyed < 1)
            transform.localScale *= secondsUntilDestroyed; //Vector3.one * secondsUntilDestroyed;

        if (secondsUntilDestroyed < 0)
            Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == ("Obstacle"))
        {
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
        }
    }
}
