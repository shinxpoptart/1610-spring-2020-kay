using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]

public class CharacterMover : MonoBehaviour
{
    public Vector3 positionDirection;
    private CharacterController controller;
    public float speed = 10f;
    public float gravity = 3f;
    public float jumpForce = 20f;
    public int jumpCount = 1;
    public int jumpCountMax = 3;
    public UnityEvent jumpEvent;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        //if (controller.isGrounded)
        {
            //positionDirection.y = 0;
            //jumpCount = 0;
        }
        controller.Move(positionDirection*Time.deltaTime);
        positionDirection.x = Input.GetAxis("Horizontal")*speed;
        positionDirection.z = Input.GetAxis("Vertical")*-speed;

        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            jumpEvent.Invoke();
            positionDirection.y = jumpForce;
        }
        
        positionDirection.y -= gravity;
        

    }
}
