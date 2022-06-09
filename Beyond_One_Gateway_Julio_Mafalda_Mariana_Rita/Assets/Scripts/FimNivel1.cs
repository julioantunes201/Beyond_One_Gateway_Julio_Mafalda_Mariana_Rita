using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FimNivel1 : MonoBehaviour
{
    public static int conta;
    // Start is called before the first frame update
    void Start()
    {
        
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
            conta = GameObject.FindGameObjectWithTag("Player").GetComponentInParent<PontosColetados>().points;
            if (conta >= 1)
            {
                Debug.Log("Ganhaste");
                SceneManager.LoadScene("Escolher_nivel_estrelas");
            } else{
                Debug.Log("Perdeste");
                SceneManager.LoadScene("Escolher_nivel_estrelas");
            }
        }
    }
}
