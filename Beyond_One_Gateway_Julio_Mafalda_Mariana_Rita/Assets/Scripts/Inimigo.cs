using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Inimigo : MonoBehaviour
{
    NavMeshAgent agente;
    Transform alvo;
    private AudioSource som;
    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        alvo = GameObject.FindGameObjectWithTag("Player").transform;
        som = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        agente.destination = alvo.position;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Inimigo_canvas.gameover = true;
            som.Play();
        }
       
    }
}
