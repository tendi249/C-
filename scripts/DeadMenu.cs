using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMenu : MonoBehaviour
{
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Resawn()
    {
        SceneManager.LoadScene("Game");
    }

    void Start()
    {
        Screen.lockCursor = false;
    }
}
