using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(message:"OnTriggerEnter");
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(message:"OnCollisionEnter");
    }
}
