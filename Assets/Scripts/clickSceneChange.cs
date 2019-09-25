using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickSceneChange : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("MainGameScene");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
    public void GotoOptionScene()
    {
        SceneManager.LoadScene("option");
    }
    public void GotoshopScene()
    {
        SceneManager.LoadScene("shop");
    }
}   
