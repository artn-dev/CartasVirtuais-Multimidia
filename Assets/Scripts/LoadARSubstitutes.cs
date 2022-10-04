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
        GameObject marker = GameObject.Find("clubs-king");

        Instantiate(virtualCard, marker.transform);
    }
}
