using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Para_plataforma : MonoBehaviour
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
        if (other.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("plataforma").GetComponent<Animator>().Play("Para_plataforma");
        }

    }
}
