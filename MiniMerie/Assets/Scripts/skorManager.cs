using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skorManager : MonoBehaviour
{
    public GameObject textSkor;

    public Text skor;

    public int toplananAltin;


    void Start()
    {
        skor = textSkor.GetComponent<Text>();
        toplananAltin = 0;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag =="altin")
        {
            skor.text = "skor" + toplananAltin;
            toplananAltin++;
        }
        

    }
}
