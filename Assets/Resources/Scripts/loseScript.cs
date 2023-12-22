using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loseScript : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject losePanel;
    public GameObject winPanel;

    [Header("Win values")]
    public float moneyToWin;

    //[Header("Scene Objects")]
    //public GameObject[] objects;
    private GameObject[] turrets;

    public void Win()
    {
        losePanel.SetActive(false);
        winPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Lose()
    {
        losePanel.SetActive(true);
        winPanel.SetActive(false);
        Time.timeScale = 0;
        //Application.Quit();
    }

    public void PlayAgain()
    {
        losePanel.SetActive(false);
        winPanel.SetActive(false);
        Time.timeScale = 1;
        GetComponent<BaseScript>().baseMoney = 100;
        turrets = GameObject.FindGameObjectsWithTag("Player");
        foreach(GameObject turret in turrets)
        {
            Destroy(turret);
        }
    }
}
