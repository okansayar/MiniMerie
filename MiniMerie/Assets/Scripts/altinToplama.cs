using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altinToplama : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D col) // 
    {
           if(col.gameObject.tag=="Player") // ana kkarakktere player tagý verdik  altýnlarý verdik ve karakter adýnda   sorting layer oluþturduk. kodu altýnlara attýk
        {
            Destroy(this.gameObject);
        }
    }
    void Update()
    {
        
    }
}
