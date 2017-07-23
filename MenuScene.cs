using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour {

	

    
     
    
   public void HighScore()
    {
        SceneManager.LoadScene("HighScoreBadger");
    }
    public void Jabuszka()
    {
        SceneManager.LoadScene("CollectApples");
    }
    public void MaineMeny()
    {
        SceneManager.LoadScene("Menu");
    }
}



