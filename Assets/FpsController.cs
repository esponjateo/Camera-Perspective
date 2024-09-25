using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FpsController : MonoBehaviour
{

    public Camera PlayerCamera;

    float walkspeed = 7f;
    float runspeed = 12f;
    float Jumppower = 10;
    float gravity = 10;

    float lookspeed = 2f;
    float lookXmax = 45f;


    Vector3 movedirection = Vector3.zero;
    float rotationX = 0;

    bool CanMove = true;

    CharacterController Charactercontroller;

     void Start()
     {
      Charactercontroller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
     }


    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        bool Isrunning = Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = CanMove ? (Isrunning ? runspeed : walkspeed) * Input.GetAxis("vertical") : 0;
        float curSpeedY = CanMove ? (Isrunning ? runspeed : walkspeed) * Input.GetAxis("Horizontal") : 0;
        float movementDirectionY = movedirection.y;
        movedirection = (forward * curSpeedX) + (right * curSpeedY);


        if (Input.GetButton("jump") && CanMove && Charactercontroller.isGrounded)
        {
            movedirection.y
        }


    }









}



