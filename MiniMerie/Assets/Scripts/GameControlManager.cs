using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlManager : MonoBehaviour
{ 
    public void TekrarOyna()
    {
        SceneManager.LoadScene(0);
    }
    
    void Update()
    {
        
    }
}
