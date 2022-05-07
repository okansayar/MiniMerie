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
        if (Input.GetKeyDown(KeyCode.Space) && yerdeMi == true) // havadayken z�playamas�n yerde z�plas�n
        {
            yerdeMi = false;
            anim.SetBool("zipladimi", true);
            GetComponent<Rigidbody2D>().velocity += new Vector2(0, 7f);
        }
    }

    // Update is called once per frame
    void FixedUpdate() // ko�ma i�lemi
    {  
        Horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(Horizontal,0,0)*hiz; // sa�a ve sola hareket etmesini sa�layan kod 

       if(Horizontal==1)  
        {
            transform.localScale = new Vector3(1, 1, 1); // y�n tu�lar�na bast���n da karakterin de y�z�nn d�nme i�lemi
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

        if (Input.GetKey(KeyCode.A)) //  y�n ttu�lar�una bast���n anda d�nme i�lemi ger�ekle�tirir.
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (Input.GetKey(KeyCode.D)) 
       {
            transform.localScale = new Vector3(1, 1, 1); 
       }
    }

    private void OnCollisionEnter2D(Collision2D col) // �arp��ma olunca tetiklenir. ana karakter zemine �arpt���n da z�plama �al���r.
    {
        if (col.gameObject.tag == "Zemin")
        {
            yerdeMi = true;
            anim.SetBool("zipladimi", false);
        }
    }
}
