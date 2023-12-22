using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void FirstLVLStart()
    {
        SceneManager.LoadScene("Level1");
    }

    public void SecondLVLStart()
    {
        SceneManager.LoadScene("Level2");
    }

    public void ThirdLVLStart()
    {
        SceneManager.LoadScene("Level3");
    }
}
