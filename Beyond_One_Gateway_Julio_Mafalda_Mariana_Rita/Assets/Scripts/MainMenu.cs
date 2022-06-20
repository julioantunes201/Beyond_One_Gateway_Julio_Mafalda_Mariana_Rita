using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("02_CutScene_CineMachine");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
