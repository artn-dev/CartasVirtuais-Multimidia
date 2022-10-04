using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    static public string virtualCardsFolderPath = "Cards/Example";

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void SetVirtualCards(string folderPath)
    {
        virtualCardsFolderPath = folderPath;
    }
}
