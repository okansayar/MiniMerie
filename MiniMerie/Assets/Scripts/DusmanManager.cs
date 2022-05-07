using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanManager : MonoBehaviour
{

    public GameObject kaybettinizPanel;

  
    void Start()
    {
        kaybettinizPanel.SetActive(false);

    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="Player")
        {
            kaybettinizPanel.SetActive(true);
            Time.timeScale = 1; // oyundaki zamaný durdurmak için
        }
    }
}
