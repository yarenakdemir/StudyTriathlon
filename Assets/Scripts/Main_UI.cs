using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Main_UI : MonoBehaviour
{
    public Text text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text =System.DateTime.Now.ToString();
    }
}
