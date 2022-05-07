using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterKontrol : MonoBehaviour
{
    public float Horizontal;
    public float hiz;
    public bool yerdeMi;

    public Animator anim;

    void Start()
    {
        yerdeMi = true;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && yerdeMi == true) // havadayken zýplayamasýn yerde zýplasýn
        {
            yerdeMi = false;
            anim.SetBool("zipladimi", true);
            GetComponent<Rigidbody2D>().velocity += new Vector2(0, 7f);
        }
    }

    // Update is called once per frame
    void FixedUpdate() // koþma iþlemi
    {  
        Horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(Horizontal,0,0)*hiz; // saða ve sola hareket etmesini saðlayan kod 

       if(Horizontal==1)  
        {
            transform.localScale = new Vector3(1, 1, 1); // yön tuþlarýna bastýðýn da karakterin de yüzünn dönme iþlemi
            anim.SetBool("kosuyormu", true); // 
        }
       else if(Horizontal==-1)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            anim.SetBool("kosuyormu", true);
        }
       else
        {

            anim.SetBool("kosuyormu",false);
        }

        if (Input.GetKey(KeyCode.A)) //  yön ttuþlarýuna bastýðýn anda dönme iþlemi gerçekleþtirir.
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (Input.GetKey(KeyCode.D)) 
       {
            transform.localScale = new Vector3(1, 1, 1); 
       }
    }

    private void OnCollisionEnter2D(Collision2D col) // çarpýþma olunca tetiklenir. ana karakter zemine çarptýðýn da zýplama çalýþýr.
    {
        if (col.gameObject.tag == "Zemin")
        {
            yerdeMi = true;
            anim.SetBool("zipladimi", false);
        }
    }
}
