using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class grabItem : MonoBehaviour
{
    [SerializeField]
    private Camera fpCamera;

    [SerializeField]
    private Transform itemSlot;

    private itemPickUp pickUp;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            if (pickUp)
            {
                //;
            }
        }
        

    }
}
