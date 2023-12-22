using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject playPanel;
    public GameObject settingsPanel;



    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void SettingsButton()
    {
        playPanel.SetActive(false);
        settingsPanel.SetActive(false);
    }
}
