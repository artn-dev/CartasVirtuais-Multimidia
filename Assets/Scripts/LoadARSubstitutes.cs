using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;
using TMPro;

public class LoadARSubstitutes : MonoBehaviour
{
    void Start()
    {
        string virtualCardsPath = MainMenu.virtualCardsFolderPath;

        if (virtualCardsPath == "")
            return;

        List<GameObject> virtualCards = GetVirtualCards(virtualCardsPath);
        GameObject markersParent = GameObject.Find("Markers");
        int i = 0;

        foreach (Transform t in markersParent.transform.GetComponentInChildren<Transform>())
        {
            Instantiate(virtualCards[i], t);

            if (++i >= virtualCards.Count)
                break;
        }
    }

    private List<GameObject> GetVirtualCards(string path)
    {
        Debug.Log("Loading cards from: " + path);
        var loadedObjects = Resources.LoadAll(path, typeof(GameObject)).Cast<GameObject>();

        List<GameObject> virtualCards = new List<GameObject>();
        foreach (var loadedObject in loadedObjects)
        {
            virtualCards.Add(loadedObject as GameObject);
        }

        return virtualCards;
    }
}
