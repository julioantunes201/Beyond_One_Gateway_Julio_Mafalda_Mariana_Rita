using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transicao_jogo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Contagem());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Contagem()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("03_Gameplay");
        
    }
}
