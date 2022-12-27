using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public GameObject enemy; //enemy movement
    public GameObject player; //what the enemy will follow

    public float speed;


    // Update is called once per frame
    void Update()
    {
        transform.
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
            speed = 0f;
    }

    void OnTriggerExit(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
            speed = 2f;
    }

}
