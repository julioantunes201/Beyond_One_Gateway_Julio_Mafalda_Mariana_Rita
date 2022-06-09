using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    [SerializeField] float duracao = 1f;
    void Start()
    {
        
        //matamos o coletavel à nascença
    }

    // Update is called once per frame
    void Update()
    {
        duracao -= Time.deltaTime;
        if (duracao < 0)
        {
            gameObject.SetActive(false);
            GameObject.Find("Plane").GetComponent<Jogo>().instanciar = true;
        }
        transform.Rotate(new Vector3(15, 15, 0) * Time.deltaTime);
    }
    private void OnDestroy()
    {
        //vamos informar o jogo que tem de instanciar novo coletavel
        
    }

}
