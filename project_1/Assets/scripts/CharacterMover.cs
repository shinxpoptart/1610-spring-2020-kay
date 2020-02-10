using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterMover : MonoBehaviour
{
    public Vector3 positionDirection;
    private CharacterController controller;
    public float speed = 10f;
    public float gravity = 3f;
    public float jumpForce = 20f;
    private int jumpCount = 0;
    public int jumpCountMax = 2;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        if (controller.isGrounded)
        {
            positionDirection.y = 0;
            jumpCount = 0;
        }
        controller.Move(positionDirection*Time.deltaTime);
        positionDirection.x = Input.GetAxis("Horizontal")*speed;

        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            positionDirection.y = jumpForce;
            jumpCount++;
        }
        
        positionDirection.y -= gravity;
        

    }
}
