using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
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
        // Som ativa sempre que o jogador entra na zona 
        /*
        if (other.CompareTag("colect"))
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponentInParent<Game>().instanciar = false;
            
        }*/
        if (other.gameObject.CompareTag("colect"))
        {
            Destroy(other.gameObject);
        }
    }
}