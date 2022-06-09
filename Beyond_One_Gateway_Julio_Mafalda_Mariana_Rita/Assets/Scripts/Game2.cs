using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game2 : MonoBehaviour
{
    [SerializeField] GameObject Colect;
    [SerializeField] Transform[] coordinate = new Transform[2];
    private int sorteado = 0;
    public bool instanciar = true;

    // Update is called once per frame
    void Update()
    {
        if (instanciar)
        {
            instanciar = false;
            Invoke("InstanciaColetavel", Random.Range(1, 2));
        }
    }

    void InstanciaColetavel()
    {
        sorteado = Sorteio(0, 2);
        Instantiate(Colect, coordinate[sorteado].position, Quaternion.identity);
    }

    int Sorteio(int minimo, int maximo)
    {
        Random.InitState((int)System.DateTime.Now.Ticks);
        return minimo + (sorteado - minimo + Random.Range(0, maximo - minimo)) % (maximo - minimo);
    }
}
