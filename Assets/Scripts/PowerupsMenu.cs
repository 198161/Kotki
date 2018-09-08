using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerupsMenu : MonoBehaviour
{

    public CoinAmmount coin; //Stan konta/liczba kredytów
    public int HeartsMax = 3; //Maksymalna liczba żyć
    public int GameSpeed = 0; //Prędkość gry
    public int GameSpeedMax = 9; //Maksymalna prędkość gry
    public int cost1; //Koszt żyć
    public int cost2; //Koszt GameSpeed
    public Text HeartsText; //Wyświetla liczbę żyć
    public Text GameSpeedText; //Wyświetla aktualną prędkość gry
    string licz = "0";

    // Use this for initialization
    void Start()
    {
        GameControlScript.health = 3;
        coin.coinNumber = PlayerPrefs.GetInt("Coins,0"); //Rekuperacja ilośći kredytów
    }




    public void Update()
    {
        HeartsText.text = GameControlScript.health.ToString();
        GameSpeedText.text = CatWalk.Przelicznikpredkosci.ToString();

    }



    public void BuyHearts() //Funkcja kupowania życia
    {
        if (coin.coinNumber >= cost1) //Sprawdzenie czy liczba kredytów za "Hearts" jest wystarczająca
        {

            if (GameControlScript.health < HeartsMax)
            {
                coin.coinNumber -= cost1; //Odejmowanie kredytów za "Hearts" od całkowitej liczy kredytów
                GameControlScript.health++;
            }
            else
            {

            }
        }
    }

    public void BuyGameSpeed()
    {
        if (CatWalk.Przelicznikpredkosci < GameSpeedMax && CatWalk.Przelicznikpredkosci > 1 && coin.coinNumber >= 200)
        {
            coin.coinNumber -= cost2;
            CatWalk.speed -= 1.8f;
            CatWalk.Przelicznikpredkosci -= 1;
        }
    }

    void OnDestroy() //Zapisywanie z PlayerPrefs
    {
        PlayerPrefs.SetInt("Coins", coin.coinNumber);
        PlayerPrefs.Save();
    }
}

