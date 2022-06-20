using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporizador : MonoBehaviour
{
    public static float temporizador = 80;
    //[SerializeField] float temporizador = 10;
    [SerializeField] Text mostrador;
    public static bool contaTempo = true;

    private void Update()
    {
        ContadorTemporal();
    }
    public void ContadorTemporal()
    {
        MostraTempo(temporizador);
        if (contaTempo)
        {
            if(temporizador > 0)
            {
                temporizador -= Time.deltaTime;
            }else
            {
                temporizador = 0;
                contaTempo = false;
                AcabaTempo_canvas.gameovertempo = true;
            }
        }
    }
    void MostraTempo(float relogio)
    {
        float minutos = Mathf.FloorToInt(relogio / 60);
        float segundos = Mathf.FloorToInt(relogio % 60);

        mostrador.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }
    
}
