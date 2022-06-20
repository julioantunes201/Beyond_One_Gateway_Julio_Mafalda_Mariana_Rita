using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AcabaTempo_canvas : MonoBehaviour
{
    private AudioSource som;
    public static bool gameovertempo = false;
    [SerializeField] GameObject paineltempo;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnlvl1;
    [SerializeField] AudioSource m_MyAudioSource;
    

    // Update is called once per frame
    void Update()
    {
        if (gameovertempo)
        {
            Time.timeScale = 0f;
            paineltempo.SetActive(true);
            GameObject.Find("end_lvl1").GetComponent<FimNivel1>().SemColetaveis.SetActive(false);
            GameObject.Find("end_lvl1").GetComponent<FimNivel1>().nivel2.SetActive(false);
            m_MyAudioSource.Stop();
        }
    }

    public void SairJogo()
    {
        Application.Quit();
    }

    public void ReiniciarJogo()
    {
        Temporizador.temporizador = 200;
        Time.timeScale = 1f;
        Temporizador.contaTempo = true;
        paineltempo.SetActive(false);
        gameovertempo = false;
        player.transform.position = respawnlvl1.transform.position;
        m_MyAudioSource.Play();
    }
}
