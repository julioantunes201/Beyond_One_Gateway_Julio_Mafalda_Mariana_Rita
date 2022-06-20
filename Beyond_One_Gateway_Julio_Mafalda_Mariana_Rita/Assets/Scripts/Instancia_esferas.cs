using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancia_esferas : MonoBehaviour
{
    public GameObject esfera1;
    public GameObject esfera2;
    public GameObject esfera3;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void Delay()
    {
        Instantiate(esfera1, new Vector3(193, 2, 122), Quaternion.identity);
        Instantiate(esfera2, new Vector3(193, 2, 122), Quaternion.identity);
        Instantiate(esfera3, new Vector3(193, 2, 122), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.isPaused)
        {
            Delay();
        }
    }
}
