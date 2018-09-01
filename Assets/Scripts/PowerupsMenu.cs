using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerupsMenu : MonoBehaviour {

    public CoinAmmount coin; //Stan konta/liczba kredytów
    public int Hearts = 0; //Życie
    public int HeartsMax = 3; //Maksymalna liczba żyć
    public int GameSpeed = 0; //Prędkość gry
    public int GameSpeedMax = 9; //Maksymalna prędkość gry
    public int cost1; //Koszt żyć
    public int cost2; //Koszt GameSpeed
    public Text HeartsText; //Wyświetla liczbę żyć
    public Text GameSpeedText; //Wyświetla aktualną prędkość gry

    // Use this for initialization
    void Start ()
    {
        coin.coinNumber = PlayerPrefs.GetInt("Coins,0"); //Rekuperacja ilośći kredytów
        Hearts = PlayerPrefs.GetInt("Hearts", 0); //Rekuperacja ilośći żyć
        GameSpeed = PlayerPrefs.GetInt("GameSpeed", 0); //Rekuperacja prędkości gry
        UpdateHeartsText(); //Funkcja do pokazania ilości żyć
        UpdateGameSpeedText(); //Funckja do pokazania prędkości gry

    }
	
	// Update is called once per frame
	public void UpdateHeartsText ()
    {
        HeartsText.text = Hearts.ToString(); //String używany do update'u życia
	}

    public void UpdateGameSpeedText()
    {
        GameSpeedText.text = GameSpeed.ToString(); //String używany do update'u prędkości gry
    }

    public void BuyHearts() //Funkcja kupowania życia
    {
        if(coin.coinNumber >= cost1) //Sprawdzenie czy liczba kredytów za "Hearts" jest wystarczająca
        {
            if(Hearts < HeartsMax)
            {
                coin.coinNumber -= cost1; //Odejmowanie kredytów za "Hearts" od całkowitej liczy kredytów
                Hearts++;
                UpdateHeartsText(); //Zwiększa się +1
            }
            else
            {

            }
        }
    }

    public void BuyGameSpeed()
    {
        if (GameSpeed < GameSpeedMax)
        {
            coin.coinNumber -= cost2;
            GameSpeed++;
            UpdateGameSpeedText();
        }  
    }

    void OnDestroy() //Zapisywanie z PlayerPrefs
    {
        PlayerPrefs.SetInt("Hearts", Hearts);
        PlayerPrefs.SetInt("GameSpeed", GameSpeed);
        PlayerPrefs.SetInt("Coins", coin.coinNumber);
        PlayerPrefs.Save();
    }
}

