using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoad : MonoBehaviour
{

    // Use this for initialization
    public void LoadScene()
    {
        SceneManager.LoadScene("Game");
    }

}
