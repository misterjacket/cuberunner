using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        float percentage = (FindObjectOfType<EndTrigger>().transform.position.z - player.position.z);

        if (percentage > 0)
            scoreText.text = string.Concat(percentage.ToString("0"), "m");
    }
}
