using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jogo : MonoBehaviour
{
    [SerializeField] Transform[] coordenadas = new Transform[2]; //coordenadas possíveis para instanciar o coletavel
    [SerializeField] GameObject coletavel; //Prefab para instanciar
    public bool instanciar = true; //só instancia quando a variavel é true
    //vamos evitar repetições e garantir que passamos por todas as salas
    private int[] preenchidos = new int[2]; //garantimos que todas as posições são preenchidas
    private int contaPreenchidos = 0;       //quando preenchemos o vetor fazemos reset

    // Instanciar coletaveis
    void Start()
    {
        ResetPreenchidos();
    }

    // Update is called once per frame
    void Update()
    {
        if(instanciar) InstanciaColetavel();
    }
    void InstanciaColetavel()
    {
        instanciar = false; //para não ser instanciado repetidamente
        Instantiate(coletavel, coordenadas[Sorteio()].position, Quaternion.identity);
    }

    private int Sorteio()
    {
        //sorteamos apenas as posições livres
        int sorteado = 0;
        bool livre = false;
        while(livre == false)
        {
            sorteado = Random.Range(0, 2);//sorteamos um número de 0 a 4
            //procuramos uma posição no vetor que esteja livre
            Debug.Log("Sorteado " + sorteado + " 0 = " + preenchidos[0] + " 1 = " + preenchidos[1]);
            if (preenchidos[sorteado] == 0)
            {
                preenchidos[sorteado] = 2;
                livre = true; //sai do ciclo pois já foi ocupado
                
            }
        }
        contaPreenchidos++;
        if (contaPreenchidos >= 2) ResetPreenchidos();
        return sorteado;
    }
    void ResetPreenchidos()
    {
        contaPreenchidos = 0;
        for(int i = 0; i < preenchidos.Length; i++)
        {
            preenchidos[i] = 0;
        }
    }
}