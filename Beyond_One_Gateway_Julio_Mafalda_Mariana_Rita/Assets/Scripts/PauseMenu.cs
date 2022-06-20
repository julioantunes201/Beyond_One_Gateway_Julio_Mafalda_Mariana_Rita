using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;
    [SerializeField] AudioSource m_MyAudioSource;
    [SerializeField] AudioSource m_SomNivel2;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {

                PauseGame();
            }

          
        }
    }

    public void PauseGame()
    {
        //GameObject.FindGameObjectWithTag("Player").SetActive(false);
        //GameObject.FindGameObjectWithTag("Cinemachine").SetActive(true);
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        m_MyAudioSource.Stop();
        m_SomNivel2.Stop();
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        m_MyAudioSource.Play();
        m_SomNivel2.Play();
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("01_MenuInicial");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}