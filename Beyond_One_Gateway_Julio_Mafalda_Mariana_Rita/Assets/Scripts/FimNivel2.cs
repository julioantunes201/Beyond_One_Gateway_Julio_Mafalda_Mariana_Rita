using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FimNivel2 : MonoBehaviour
{
    public static int conta2;
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //PontosColetados.points = conta;

            conta2 = GameObject.FindGameObjectWithTag("Player").GetComponentInParent<PontosColetados>().points;
            if (conta2 >= 1)
            {
                m_MyAudioSource.Stop();
                m_nivel2.Play();
                SemColect.Stop();
                nivel2.SetActive(true);
                GameObject.FindGameObjectWithTag("Player").GetComponentInParent<PontosColetados>().points = 0;
            }
            else
            {
                SemColetaveis.SetActive(true);
                SemColect.Play();
                Time.timeScale = 0f;
                Temporizador.temporizador = 80;
            }
            Temporizador.temporizador = 150;
        }
    }
}
