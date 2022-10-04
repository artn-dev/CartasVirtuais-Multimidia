using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class LoadARSubstitutes : MonoBehaviour
{
    public GameObject marker;

    void Start()
    {
        GameObject virtualCard = Resources.Load("Cards/Example/IMG-00") as GameObject;
        GameObject markersParent = GameObject.Find("Markers");
        
        foreach (Transform t in markersParent.transform.GetComponentInChildren<Transform>())
        {
            Instantiate(virtualCard, t);
        }
    }
}
