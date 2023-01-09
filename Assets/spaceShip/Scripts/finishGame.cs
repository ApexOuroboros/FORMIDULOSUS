using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishGame : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("MainMenu");
    }
    //when player collides with the space ship, they will be taken back to the main menu
}
