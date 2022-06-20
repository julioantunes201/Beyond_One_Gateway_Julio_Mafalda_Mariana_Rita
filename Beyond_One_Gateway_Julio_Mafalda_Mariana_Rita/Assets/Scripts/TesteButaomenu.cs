using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TesteButaomenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("01_MenuInicial");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
