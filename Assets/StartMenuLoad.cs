using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuLoad : MonoBehaviour
{

    // Use this for initialization
    public void LoadScene()
    {
        SceneManager.LoadScene("Main");
    }

}
