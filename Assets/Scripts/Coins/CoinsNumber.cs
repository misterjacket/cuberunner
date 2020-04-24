using UnityEngine;
using UnityEngine.UI;

public class CoinsNumber : MonoBehaviour
{
    public Text coinAmountText;

    public void UpdateCoinText()
    {
        int currentCoins = int.Parse(coinAmountText.text)+1;
        coinAmountText.text = currentCoins < 10 ? string.Concat("0", currentCoins.ToString("0")) : currentCoins.ToString("0");
    }
}
