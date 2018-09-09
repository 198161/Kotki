using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CatMenu : MonoBehaviour {
    public CoinAmmount coin;
    public Button cat1Button;
    public Button cat2Button;
    public Button cat3Button;
    public Button cat4Button;
    public Button cat5Button;
    public Button cat6Button;
    bool cat1; 
    bool cat2;
    bool cat3;
    bool cat4;
    bool cat5;
    bool cat6;
    bool useCat1;
    bool useCat2;
    bool useCat3;
    bool useCat4;
    bool useCat5;
    bool useCat6;
    // Use this for initialization
    void Start () {
        coin.coinNumber = PlayerPrefs.GetInt ("Coins,0");
        cat1 = PlayerPrefs.GetInt("Cat1",0) == 1;
        cat2 = PlayerPrefs.GetInt("Cat2",0) == 1;
        cat3 = PlayerPrefs.GetInt("Cat3",0) == 1;
        cat4 = PlayerPrefs.GetInt("Cat4",0) == 1;
        cat5 = PlayerPrefs.GetInt("Cat5",0) == 1;
        cat6 = PlayerPrefs.GetInt("Cat6",0) == 1;
        useCat1 = PlayerPrefs.GetInt("useCat1", 0) == 1;
        useCat2 = PlayerPrefs.GetInt("useCat2", 0) == 1;
        useCat3 = PlayerPrefs.GetInt("useCat3", 0) == 1;
        useCat4 = PlayerPrefs.GetInt("useCat4", 0) == 1;
        useCat5 = PlayerPrefs.GetInt("useCat5", 0) == 1;
        useCat6 = PlayerPrefs.GetInt("useCat6", 0) == 1;
    }
	
	// Update is called once per frame
	void Update () {
		if(cat1) //Czy mamy tę skórkę?
        {
            if(useCat1) //On/Off cat1
            {
                cat1Button.GetComponent<Image>().color = Color.green; //Jeżeli używamy skórkę, to kolor ramki zmienia się na zielony
                CatSpa.whichAvatarIsOn = 1;
                Debug.Log("Cat skin 1 has been used");
                if(useCat1) //Wyłączenie reszty nieużywanych skórek
                {
                    useCat1 = true; //W użyciu
                    useCat2 = false; //Wyłączone
                    useCat3 = false; //Wyłączone
                    useCat4 = false; //Wyłączone
                    useCat5 = false; //Wyłączone
                    useCat6 = false; //Wyłączone
                }
            }
            else
            {
                cat1Button.GetComponent<Image>().color = Color.blue; //Jeżeli nie używamy skórki, to kolor ramki zmienia się na niebieski
                Debug.Log("Cat skin 1 can not be used");
            }
        }
        else
        {
            NewMethod();
        }

        if (cat2) //Czy mamy tę skórkę?
        {
            if (useCat2) //On/Off cat1
            {
                cat2Button.GetComponent<Image>().color = Color.green; //Jeżeli używamy skórkę, to kolor ramki zmienia się na zielony
                CatSpa.whichAvatarIsOn = 2;
                Debug.Log("Cat skin 2 has been used");
                if (useCat2) //Wyłączenie reszty nieużywanych skórek
                {
                    useCat1 = false; //Wyłączone
                    useCat2 = true; //W użyciu
                    useCat3 = false; //Wyłączone
                    useCat4 = false; //Wyłączone
                    useCat5 = false; //Wyłączone
                    useCat6 = false; //Wyłączone
                }
            }
            else
            {
                cat2Button.GetComponent<Image>().color = Color.blue; //Jeżeli nie używamy skórki, to kolor ramki zmienia się na niebieski
                Debug.Log("Cat skin 2 can not be used");
            }
        }
        else
        {
            if (coin.coinNumber >= 300) //Jeżeli mamy wystarczającą liczbę kredytów
            {
                cat2Button.enabled = true; //Ramka jest aktywna
                cat2Button.GetComponent<Image>().color = Color.white;
            }
            else
            {
                cat2Button.enabled = false; //Nie mamy wystarczającej liczbby kredytów
                cat2Button.GetComponent<Image>().color = Color.red;
            }
        }

        if (cat3) //Czy mamy tę skórkę?
        {
            if (useCat3) //On/Off cat1
            {
                cat3Button.GetComponent<Image>().color = Color.green; //Jeżeli używamy skórkę, to kolor ramki zmienia się na zielony
                CatSpa.whichAvatarIsOn = 3;
                Debug.Log("Cat skin 3 has been used");
                if (useCat3) //Wyłączenie reszty nieużywanych skórek
                {
                    useCat1 = false; //Wyłączone
                    useCat2 = false; //Wyłączone
                    useCat3 = true; //W użyciu
                    useCat4 = false; //Wyłączone
                    useCat5 = false; //Wyłączone
                    useCat6 = false; //Wyłączone
                }
            }
            else
            {
                cat3Button.GetComponent<Image>().color = Color.blue; //Jeżeli nie używamy skórki, to kolor ramki zmienia się na niebieski
                Debug.Log("Cat skin 3 can not be used");
            }
        }
        else
        {
            if (coin.coinNumber >= 300) //Jeżeli mamy wystarczającą liczbę kredytów
            {
                cat3Button.enabled = true; //Ramka jest aktywna
                cat3Button.GetComponent<Image>().color = Color.white;
            }
            else
            {
                cat3Button.enabled = false; //Nie mamy wystarczającej liczbby kredytów
                cat3Button.GetComponent<Image>().color = Color.red;
            }
        }

        if (cat4) //Czy mamy tę skórkę?
        {
            if (useCat4) //On/Off cat1
            {
                cat4Button.GetComponent<Image>().color = Color.green; //Jeżeli używamy skórkę, to kolor ramki zmienia się na zielony
                CatSpa.whichAvatarIsOn = 4;
                Debug.Log("Cat skin 4 has been used");
                if (useCat4) //Wyłączenie reszty nieużywanych skórek
                {
                    useCat1 = false; //Wyłączone
                    useCat2 = false; //Wyłączone
                    useCat3 = false; //Wyłączone
                    useCat4 = true; //W użyciu
                    useCat5 = false; //Wyłączone
                    useCat6 = false; //Wyłączone
                }
            }
            else
            {
                cat4Button.GetComponent<Image>().color = Color.blue; //Jeżeli nie używamy skórki, to kolor ramki zmienia się na niebieski
                Debug.Log("Cat skin 4 can not be used");
            }
        }
        else
        {
            if (coin.coinNumber >= 200) //Jeżeli mamy wystarczającą liczbę kredytów
            {
                cat4Button.enabled = true; //Ramka jest aktywna
                cat4Button.GetComponent<Image>().color = Color.white;
            }
            else
            {
                cat4Button.enabled = false; //Nie mamy wystarczającej liczbby kredytów
                cat4Button.GetComponent<Image>().color = Color.red;
            }
        }

        if (cat5) //Czy mamy tę skórkę?
        {
            if (useCat5) //On/Off cat1
            {
                cat5Button.GetComponent<Image>().color = Color.green; //Jeżeli używamy skórkę, to kolor ramki zmienia się na zielony
                CatSpa.whichAvatarIsOn = 5;
                Debug.Log("Cat skin 5 has been used");
                if (useCat5) //Wyłączenie reszty nieużywanych skórek
                {
                    useCat1 = false; //Wyłączone
                    useCat2 = false; //Wyłączone
                    useCat3 = false; //Wyłączone
                    useCat4 = false; //Wyłączone
                    useCat5 = true; //W użyciu
                    useCat6 = false; //Wyłączone
                }
            }
            else
            {
                cat5Button.GetComponent<Image>().color = Color.blue; //Jeżeli nie używamy skórki, to kolor ramki zmienia się na niebieski
                Debug.Log("Cat skin 5 can not be used");
            }
        }
        else
        {
            if (coin.coinNumber >= 300) //Jeżeli mamy wystarczającą liczbę kredytów
            {
                cat5Button.enabled = true; //Ramka jest aktywna
                cat5Button.GetComponent<Image>().color = Color.white;
            }
            else
            {
                cat5Button.enabled = false; //Nie mamy wystarczającej liczbby kredytów
                cat5Button.GetComponent<Image>().color = Color.red;
            }
        }

        if (cat6) //Czy mamy tę skórkę?
        {
            if (useCat6) //On/Off cat1
            {
                cat6Button.GetComponent<Image>().color = Color.green; //Jeżeli używamy skórkę, to kolor ramki zmienia się na zielony
                CatSpa.whichAvatarIsOn = 6;
                Debug.Log("Cat skin 6 has been used");
                if (useCat6) //Wyłączenie reszty nieużywanych skórek
                {
                    useCat1 = false; //Wyłączone
                    useCat2 = false; //Wyłączone
                    useCat3 = false; //Wyłączone
                    useCat4 = false; //Wyłączone
                    useCat5 = false; //Wyłączone
                    useCat6 = true; //W użyciu
                }
            }
            else
            {
                cat6Button.GetComponent<Image>().color = Color.blue; //Jeżeli nie używamy skórki, to kolor ramki zmienia się na niebieski
                Debug.Log("Cat skin 6 can not be used");
            }
        }
        else
        {
            if (coin.coinNumber >= 400) //Jeżeli mamy wystarczającą liczbę kredytów
            {
                cat6Button.enabled = true; //Ramka jest aktywna
                cat6Button.GetComponent<Image>().color = Color.white;
            }
            else
            {
                cat6Button.enabled = false; //Nie mamy wystarczającej liczbby kredytów
                cat6Button.GetComponent<Image>().color = Color.red;
            }
        }

    }

    private void NewMethod()
    {
        if (coin.coinNumber >= 200) //Jeżeli mamy wystarczającą liczbę kredytów
        {
            cat1Button.enabled = true; //Ramka jest aktywna
            cat1Button.GetComponent<Image>().color = Color.white;
        }
        else
        {
            cat1Button.enabled = false; //Nie mamy wystarczającej liczbby kredytów
            cat1Button.GetComponent<Image>().color = Color.red;
        }
    }

    public void PurchaseCat1()
    {
        if(cat1) //Sprawdzenie skórki
        {
            useCat1 = !useCat1; //Nie używamy
        }
        else
        {
            coin.coinNumber -= 200; //Odejmowanie kredytu
            cat1 = true; //Odblokowanie skórki
        }
    }

    public void PurchaseCat2()
    {
        if (cat2) //Sprawdzenie skórki
        {
            useCat2 = !useCat2; //Nie używamy
        }
        else
        {
            coin.coinNumber -= 300; //Odejmowanie kredytu
            cat2 = true; //Odblokowanie skórki
        }
    }

    public void PurchaseCat3()
    {
        if (cat3) //Sprawdzenie skórki
        {
            useCat3 = !useCat3; //Nie używamy
        }
        else
        {
            coin.coinNumber -= 300; //Odejmowanie kredytu
            cat3 = true; //Odblokowanie skórki
        }
    }

    public void PurchaseCat4()
    {
        if (cat4) //Sprawdzenie skórki
        {
            useCat4 = !useCat4; //Nie używamy
        }
        else
        {
            coin.coinNumber -= 200; //Odejmowanie kredytu
            cat4 = true; //Odblokowanie skórki
        }
    }

    public void PurchaseCat5()
    {
        if (cat5) //Sprawdzenie skórki
        {
            useCat5 = !useCat5; //Nie używamy
        }
        else
        {
            coin.coinNumber -= 300; //Odejmowanie kredytu
            cat5 = true; //Odblokowanie skórki
        }
    }

    public void PurchaseCat6()
    {
        if (cat6) //Sprawdzenie skórki
        {
            useCat6 = !useCat6; //Nie używamy
        }
        else
        {
            coin.coinNumber -= 400; //Odejmowanie kredytu
            cat6 = true; //Odblokowanie skórki
        }
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("Coins", coin.coinNumber);
        PlayerPrefs.SetInt("cat1", cat1 ? 1 : 0);
        PlayerPrefs.SetInt("cat2", cat2 ? 1 : 0);
        PlayerPrefs.SetInt("cat3", cat3 ? 1 : 0);
        PlayerPrefs.SetInt("cat4", cat4 ? 1 : 0);
        PlayerPrefs.SetInt("cat5", cat5 ? 1 : 0);
        PlayerPrefs.SetInt("cat6", cat6 ? 1 : 0);

        PlayerPrefs.SetInt("useCat1", useCat1 ? 1 : 0);
        PlayerPrefs.SetInt("useCat2", useCat2 ? 1 : 0);
        PlayerPrefs.SetInt("useCat3", useCat3 ? 1 : 0);
        PlayerPrefs.SetInt("useCat4", useCat4 ? 1 : 0);
        PlayerPrefs.SetInt("useCat5", useCat5 ? 1 : 0);
        PlayerPrefs.SetInt("useCat6", useCat6 ? 1 : 0);

        PlayerPrefs.Save ();

    }
}