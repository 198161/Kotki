using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CoinAmmount : MonoBehaviour {
    public int coinNumber = 0; //Suma posiadanych kredytów
    public Text CoinText;
	// Use this for initialization
	void Start ()
    {
        coinNumber = PlayerPrefs.GetInt("Coins", 0); //Przywracanie liczby kredytów zebranych poprzednio
	}
	
	// Update is called once per frame
	void Update ()
    {
        CoinText.text = coinNumber.ToString();
    }
    private void CoinUpdate()
    {
        CoinText.text = coinNumber.ToString(); //Coin text update
    }
    public void AddCoins()
    {
        coinNumber += 20; //Dodajemy 20 kredytów
        CoinText.text = coinNumber.ToString();
    }
    public void OnDestroy()
    {
        PlayerPrefs.SetInt("Coins", coinNumber); //Zapisywanie kredytów które mamy
        PlayerPrefs.Save();
    }


}
