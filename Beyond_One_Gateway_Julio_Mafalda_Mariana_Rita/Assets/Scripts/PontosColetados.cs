using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontosColetados : MonoBehaviour
{
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        GUI.contentColor = Color.black;
        GUI.Label(new Rect(10, 20, 200, 30), "Score : " + points + "/2");
        GUI.skin.label.fontSize = 25;
    }
}
