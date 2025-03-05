using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void Awake()
    {
        Debug.Log(message:"你也開始Awake");
    }
    
    private void Start()
    {
        Debug.Log(message:"我在開始Start");
        
    }

    private void OnEnable()
    {
        Debug.Log(message:"她也開始OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log(message:"他也開始OnDisable");
    }
}
