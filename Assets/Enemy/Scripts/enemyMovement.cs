using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class enemyMovement : MonoBehaviour
{
    public Transform Player;
    int Speed = 4;
    int MinDist = 1;


    // Update is called once per frame
    void Start()
    {
       
    }

    //move towards the player when not rendered
    //enemy moves at set speed
    void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * Speed * Time.deltaTime;
        }
    }
}
