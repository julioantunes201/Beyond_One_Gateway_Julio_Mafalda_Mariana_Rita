using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject mapSelectionPanel;
    public GameObject[] levelSelectionPanels;

    public int stars;
    public Text startText;
    public MapSelection[] mapSelections;
    public Text[] questStarsTexts;
    public Text[] lockedStarsTexts;
    public Text[] unlockStarsTexts;


    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }

        }
        //DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        UpdateStarUI();
        UpdateLockedStarUI();
        UpdateUnlockedStarUI();
        stars = 3;
        //stars = GameObject.FindGameObjectWithTag("Player").GetComponentInParent<PontosColetados>().points;
    }

    private void UpdateLockedStarUI()
    {
        for (int i = 0; i < mapSelections.Length; i++)
        {
            questStarsTexts[i].text = mapSelections[i].questNum.ToString();

            if (mapSelections[i].isUnlock == false)
            {
                lockedStarsTexts[i].text = stars.ToString() + "/" + mapSelections[i].endLevel * 3;
            }
        }
    }
    private void UpdateUnlockedStarUI()
    {
        for (int i = 0; i < mapSelections.Length; i++)
        {
            unlockStarsTexts[i].text = stars.ToString() + "/" + mapSelections[i].endLevel * 3;
        }
    }

    private void UpdateStarUI()
    {
        startText.text = stars.ToString();
    }

    public void PressMapButton(int _mapIndex)
    {
        if (mapSelections[_mapIndex].isUnlock == true)
        {
            levelSelectionPanels[_mapIndex].gameObject.SetActive(true);
            mapSelectionPanel.gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("Not yet! Collect more stars");
        }
    }
    public void BackButton()
    {
        mapSelectionPanel.gameObject.SetActive(true);
        for (int i = 0; i < mapSelections.Length; i++)
        {
            levelSelectionPanels[i].gameObject.SetActive(false);
        }
    }
    public void SceneTransition(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }

    public void BackMapSelection()
    {
        mapSelectionPanel.gameObject.SetActive(true);
        for (int i = 0; i < mapSelections.Length; i++)
        {
            levelSelectionPanels[i].gameObject.SetActive(false);
        }
        SceneManager.LoadScene("Escolher_nivel_estrelas");
    }
}
