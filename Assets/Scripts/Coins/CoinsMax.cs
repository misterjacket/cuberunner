using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsMax : MonoBehaviour
{
    public Text coinsMaxText;

    void Start()
    {
        int amount = GameObject.FindGameObjectsWithTag("Coin").Length;
        coinsMaxText.text = amount < 10 ? string.Concat("0", amount.ToString()) : amount.ToString() ;
    }
}
