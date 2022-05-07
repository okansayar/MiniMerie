using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ziplama : MonoBehaviour
{
    public bool yerdeMi;
 
    void Start()
    {
        yerdeMi = true;
    }

   
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && yerdeMi==true) // havadayken z�playamas�n yerde z�plas�n
        {
            yerdeMi = false;
            GetComponent<Rigidbody2D>().velocity+=new Vector2(0,7f);
        }
    }

    private void OnCollisionEnter2D(Collision2D col) // �arp��ma olunca tetiklenir. ana karakter zemine �arpt���n da z�plama �al���r.
    {
        if (col.gameObject.tag=="zemin")
        {
            yerdeMi = true;
        }   
    }
}
