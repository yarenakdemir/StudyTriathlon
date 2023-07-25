using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PopUp_1 : MonoBehaviour
{
    private string input;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ReadStringInput (string s)
    {
        input = s;
        Debug.Log(input);
    }


}
