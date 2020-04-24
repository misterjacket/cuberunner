using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        // Saves the level where the player is at.
        PlayerPrefs.SetInt("CurrentLevel", SceneManager.GetActiveScene().buildIndex + 1);

        // Checks picked up coins and sets the total coins of the player.
        int coinsPickedUp = int.Parse(FindObjectOfType<CoinsNumber>().coinAmountText.text);
        int coinsInBag = PlayerPrefs.GetInt("TotalCoins", 0);
        PlayerPrefs.SetInt("TotalCoins", coinsPickedUp + coinsInBag);

        // Loads new level scene.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        FindObjectOfType<LevelNumber>().UpdateCurrentLevelNumber();
    }
}
