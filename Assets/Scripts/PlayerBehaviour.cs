//using UnityEditor.UIElements;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public GameObject bullet;
    public Rigidbody rb;
    public Joystick joystick;
    public Joystick joystick2;

    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

    public float secondsBetweenShots;
    float secondsSinceLastShot;

    public AmmoBar ammoBar;
    public int maxAmmo = 2;
    public int currentAmmo;

    void Start()
    {
        secondsSinceLastShot = secondsBetweenShots;
        currentAmmo = maxAmmo;
        ammoBar.SetMaxAmmo(maxAmmo);
        ammoBar.SetAmmoText();
    }

    void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Keyboard
        if (Input.GetAxis("Horizontal") > 0)
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if (Input.GetAxis("Horizontal") < 0)
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        // Joystick
        //if (joystick.Horizontal >= 0.2f)
        //{
            rb.AddForce(sidewayForce * joystick.Horizontal * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //}
        //else if (joystick.Horizontal <= -0.2f)
        //{
        //    rb.AddForce(sidewayForce * joystick.Horizontal * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //}
        //else
        //{
        //    rb.AddForce(0, 0, 0);
        //}

        // When player falls off ground...
        if (rb.position.y < -1f)
            FindObjectOfType<GameManager>().EndGame();

        secondsSinceLastShot += Time.deltaTime;

        // Space = fire bullet & update amount of ammo text
        if (Input.GetKeyDown(KeyCode.Space) || joystick2.Vertical >= .5f)
        {
            if (currentAmmo > 0 && secondsSinceLastShot >= secondsBetweenShots)
                Fire(1);
        }
    }

    void Fire(int ammo)
    {
        secondsSinceLastShot = 0;
        Instantiate(bullet, new Vector3(transform.position.x, 1, transform.position.z + 5), Quaternion.identity);
        currentAmmo -= ammo;
        ammoBar.SetAmmo(currentAmmo);
        ammoBar.SetAmmoText();
    }
}
