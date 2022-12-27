using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public GameObject player; //what the enemy will follow

    public float speed;


    // Update is called once per frame
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); //find the player
    }

    //move towards the player when not rendered
    //enemy moves at set speed
    private void OnBecomeInvisible()
    {
        transform.position += (player.transform.position - player.transform.forward) * speed * Time.deltaTime;
        //add something else, enemy isnt moving
    }

}
