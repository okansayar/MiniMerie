using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altinToplama : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D col) // 
    {
           if(col.gameObject.tag=="Player") // ana kkarakktere player tag� verdik  alt�nlar� verdik ve karakter ad�nda   sorting layer olu�turduk. kodu alt�nlara att�k
        {
            Destroy(this.gameObject);
        }
    }
    void Update()
    {
        
    }
}
