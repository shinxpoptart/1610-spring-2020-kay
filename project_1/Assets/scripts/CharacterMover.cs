using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public Vector3 positionDirection;
    public CharacterController controller;
    public float speed = 10f;
    public float gravity = 3f;
    public float jumpForce = 20f;
    void Start()
    {
        
    }
    
    void Update()
    {
        controller.Move(positionDirection*Time.deltaTime);
        positionDirection.x = Input.GetAxis("Horizontal")*speed;

        if (Input.GetButtonDown("Jump"))
        {
            positionDirection.y = jumpForce;
        }
        
        positionDirection.y -= gravity;

    }
}
