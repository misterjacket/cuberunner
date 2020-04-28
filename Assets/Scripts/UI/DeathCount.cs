using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathCount : MonoBehaviour
{
    public Text deathCountText;

    void Start()
    {
        deathCountText.text = PlayerPrefs.GetInt("DeathCount", 0).ToString();
    }

    public void UpdateDeathCount()
    {
        // Add 1 to death count.
        PlayerPrefs.SetInt("DeathCount", PlayerPrefs.GetInt("DeathCount", 0) + 1);

        deathCountText.text = PlayerPrefs.GetInt("DeathCount", 0).ToString();
    }
}
