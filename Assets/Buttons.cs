using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    
    public void startGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    //load game when "start" button is pressed

    public void quitGame()
    {
        Application.Quit();
    }
    //quit when "quit" button is pressed
}
