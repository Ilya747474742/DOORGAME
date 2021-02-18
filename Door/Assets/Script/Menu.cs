using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public int buildindex;
    public void Load()
    {
        SceneManager.LoadScene(buildindex);
    }
    public void ExitGame()
    {
        Debug.Log("exit");
        Application.Quit();
    }
}
