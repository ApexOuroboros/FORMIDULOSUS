using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class itemPickUp : MonoBehaviour
{
    public Transform hand;

    void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = hand.position;
        this.transform.parent = GameObject.Find("Hand").transform;

        //when the item is picked up, the items gravity will be turned off
        //if the gravity was left on, the picked up item will drop to the ground
        //item is moved to "hand" when clicked
    }

    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
    }

}
