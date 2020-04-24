using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelNumber : MonoBehaviour
{
    public Text levelNumber;

    private void Start()
    {
        levelNumber.text = SceneManager.GetActiveScene().buildIndex.ToString();
    }

    public void UpdateCurrentLevelNumber()
    {
        levelNumber.text = SceneManager.GetActiveScene().buildIndex.ToString();
    }
}
