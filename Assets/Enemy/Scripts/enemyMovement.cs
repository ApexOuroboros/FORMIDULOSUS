using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyMovement : MonoBehaviour
{
    public Transform Player;
    int speed = 1; //scary fast if speed 4
    int minDist = 1;
    public float gravity = 2f; //enemy should be less floaty than the player


    // Update is called once per frame
    void Start()
    {
        
    }

   
    //enemy moves at set speed towards the player
    //enemy is always following the player's position
    void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= minDist)
        {

            transform.position += transform.forward * speed * Time.deltaTime;
        }

    }

    //isVisible not supported on this version
    //cant make enemy stop moving when looked at without Raycast
    //OnBecomeInvisable not working 

}
