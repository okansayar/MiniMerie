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
        if (Input.GetKeyDown(KeyCode.Space) && yerdeMi==true) // havadayken zýplayamasýn yerde zýplasýn
        {
            yerdeMi = false;
            GetComponent<Rigidbody2D>().velocity+=new Vector2(0,7f);
        }
    }

    private void OnCollisionEnter2D(Collision2D col) // çarpýþma olunca tetiklenir. ana karakter zemine çarptýðýn da zýplama çalýþýr.
    {
        if (col.gameObject.tag=="zemin")
        {
            yerdeMi = true;
        }   
    }
}
