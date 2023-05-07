using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetection : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("?? "+ other.tag);  
        if(other.tag == "Ground")
        {
            Debug.Log("Fatality");    
        }
    }
}
