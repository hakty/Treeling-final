using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinText : MonoBehaviour
{
    public Text reapcoinDisplay;
    //public static float currentCoins = 0;
    public float currentCoins = 0;
    //public double currentCoins = 0;
    public Text InventoryDisplay;
    public Text ShopDisplay;

    public Text IndustryDisplay;

   
    void Start()
    {
        //stores player coin data
        if(PlayerPrefs.HasKey("CoinSystem")) {
            currentCoins = PlayerPrefs.GetFloat("CoinSystem");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        //Testing purposes
        if(Input.GetKeyDown("w")) {
            //currentCoins += 100000000;
            currentCoins += 10000;
        }
        
        if (currentCoins >= 1000000000) reapcoinDisplay.text = (currentCoins / 1000000000).ToString("F") + "B"; //1B, 10B, 100B...
        else if (currentCoins >= 1000000) reapcoinDisplay.text = (currentCoins / 1000000).ToString("F") + "M"; //1M, 10M, 100M
        else if (currentCoins >= 1000) reapcoinDisplay.text = (currentCoins / 1000).ToString("F") + "K"; //1K, 10k, 100K
        else if (currentCoins < 1000) reapcoinDisplay.text = currentCoins.ToString(); //0-999
        
        //currentCoins += 123;
        //currentCoins = 1000;
        InventoryDisplay.text = "ReapCoins: " + currentCoins;
        ShopDisplay.text = "ReapCoins: " + currentCoins;
        IndustryDisplay.text = "ReapCoins: " + currentCoins;

        //saves coin data
        //PlayerPrefs.SetInt("CoinSystem", currentCoins);
        PlayerPrefs.SetFloat("CoinSystem", currentCoins);
        
    }
}