using UnityEngine;
using UnityEngine.UI;

public class CurrentLevel : MonoBehaviour
{
    public Text currentLevel;

    private void Start()
    {
        currentLevel.text = PlayerPrefs.GetInt("CurrentLevel", 1).ToString();
    }
}
