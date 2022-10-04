using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static string virtualCardsFolderPath = "";

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void SetVirtualCards(string folderPath)
    {
        virtualCardsFolderPath = folderPath;
        Debug.Log("Virtual cards folter set to: " + folderPath);
    }
}
