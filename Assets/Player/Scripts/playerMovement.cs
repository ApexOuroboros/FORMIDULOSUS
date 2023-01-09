using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class playerMovement : MonoBehaviour
{
    CharacterController characterController;
    Transform playerContainer, cameraContainer;

    public float speed = 3.0f;
    public float jumpSpeed = 3f;
    public float mouseSensitivity = 2f;
    public float gravity = 1.6f; //moon gravity
    public float lookUpClamp = -30f;
    public float lookDawnClamp = 60;

    private Vector3 moveDirection = Vector3.zero;
    float rotateX, rotateY;

    // Start is called before the first frame update
    void Start()
    {

        Cursor.visible = true;
        characterController = GetComponent<CharacterController>();
        SetCurrentCamera();

    }

    // Update is called once per frame
    void Update()
    {

        Locomotion();
        RotateAndLook();


    }

    void SetCurrentCamera()
    {

        playerContainer = gameObject.transform.Find("container1p");
        cameraContainer = playerContainer.transform.Find("camera1pcontainer");

    }

    void Locomotion()
    {

        if (characterController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;


            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }

        }

        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);

    }

    void RotateAndLook()
    {

        rotateX = Input.GetAxis("Mouse X") * mouseSensitivity;
        rotateY -= Input.GetAxis("Mouse Y") * mouseSensitivity;

        rotateY = Mathf.Clamp(rotateY, lookUpClamp, lookDawnClamp);
        transform.Rotate(0f, rotateX, 0f);

        cameraContainer.transform.localRotation = Quaternion.Euler(rotateY, 0f, 0f);

    }

}
