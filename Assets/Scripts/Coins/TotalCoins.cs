using UnityEngine;
using UnityEngine.UI;

public class TotalCoins : MonoBehaviour
{
    public Text TotalCoinsText;
    // Start is called before the first frame update
    void Start()
    {
        TotalCoinsText.text = PlayerPrefs.GetInt("TotalCoins", 0).ToString();
    }
}
