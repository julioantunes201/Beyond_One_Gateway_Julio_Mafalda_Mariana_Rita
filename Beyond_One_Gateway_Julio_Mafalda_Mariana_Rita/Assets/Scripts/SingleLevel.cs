using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleLevel : MonoBehaviour
{
    private int levelStarsNum = 0;
    public int levelIndex;

    public void PressStarButton(int _starsNum)
    {
        levelStarsNum = _starsNum;
        if(levelStarsNum > PlayerPrefs.GetInt("Lv" + levelIndex))
        {
            PlayerPrefs.SetInt("Lv" + levelIndex, levelStarsNum);
        }
        Debug.Log("saving Data is " + PlayerPrefs.GetInt("Lv" + levelIndex));
        UIManager.instance.BackMapSelection();
    }
    
}
