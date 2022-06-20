using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inimigo_canvas : MonoBehaviour
{
    public static bool gameover = false;
    [SerializeField] GameObject painel;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnlvl2;
    [SerializeField] AudioSource m_MyAudioSource;

    // Update is called once per frame
    void Update()
    {
        if (gameover)
        {
            painel.SetActive(true);
            Time.timeScale = 0f;
            m_MyAudioSource.Stop();
        }
    }
    public void SairJogo()
    {
        Application.Quit();
    }

    public void ReiniciarJogo()
    {
        Time.timeScale = 1f;
        painel.SetActive(false);
        gameover = false;
        player.transform.position = respawnlvl2.transform.position;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        m_MyAudioSource.Play();
    }
}