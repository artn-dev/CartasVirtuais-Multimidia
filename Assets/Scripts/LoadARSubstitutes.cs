using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class LoadARSubstitutes : MonoBehaviour
{
    public TMP_Text foo;

    void Start()
    {
        foo.text = DateTime.Now.ToString();
    }
}
