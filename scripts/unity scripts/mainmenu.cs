using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void options()
    {

    }

    public void exitGame()
    {
        Application.Quit();
    }
}
