using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class enemyMovement : MonoBehaviour
{
    public Transform Player;
    int speed = 1; //scary fast if speed 4
    int minDist = 1;


    // Update is called once per frame
    void Start()
    {
        OnBecomeVisible();
    }

    //move towards the player when not rendered
    //enemy moves at set speed
    void Update()
    {
       
    }

    void OnBecomeVisible()
    {
        enabled = false;
        Debug.Log("not moving");
    }

    void OnBecomeInvisible()
    {
        Debug.Log("moving");

        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= minDist)
        {

            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }

}
