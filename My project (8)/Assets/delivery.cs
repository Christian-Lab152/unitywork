using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delivery : MonoBehaviour
{
    bool haspackage;

    private void Start() {
        Debug.Log(haspackage);
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch");
    }

    void OnTriggerEnter2D(Collider2D other)     
    {
       if (other.tag == "package")
       {
          Debug.Log("package picked up");  
          haspackage = true;
       }
    }
}
