using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FimNivel1 : MonoBehaviour
{
    public static int conta;
    public GameObject nivel2;
    public GameObject SemColetaveis;
    [SerializeField] AudioSource m_MyAudioSource;
    [SerializeField] AudioSource m_nivel2;
    [SerializeField] AudioSource SemColect;

    // Start is called before the first frame update
    void Start()
    {
        m_nivel2.Stop();
        SemColect.Stop();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Delay()
    {
       nivel2.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            conta = GameObject.FindGameObjectWithTag("Player").GetComponentInParent<PontosColetados>().points;
            if (conta >= 1)
            {
                m_MyAudioSource.Stop();
                m_nivel2.Play();
                SemColect.Stop();
                nivel2.SetActive(true);
                Invoke("Delay",3);
                GameObject.FindGameObjectWithTag("Player").GetComponentInParent<PontosColetados>().points = 0;
            } else{
                SemColetaveis.SetActive(true);
                SemColect.Play();
                Time.timeScale = 0f;
                Temporizador.temporizador = 80;
            }
            Temporizador.temporizador = 150;
        }
    }
}
