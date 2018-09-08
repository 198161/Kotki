using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{

    public Text score;
    public Text highScore;

    // Use this for initialization
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("highScore", 0).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        highScore.text = PlayerPrefs.GetInt("highScore", 0).ToString();

        int number = Score.scoreValue;
        //  score.text = number.ToString();
        if (number > PlayerPrefs.GetInt("highScore", 0))
        {
            PlayerPrefs.SetInt("highScore", number);

            highScore.text = number.ToString();

        }



    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        highScore.text = "0";


    }
}