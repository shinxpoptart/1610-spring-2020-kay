using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class rigidBodyForces : MonoBehaviour
{

    private Rigidbody rigidBodyObj;
    public float force = 100;
    private Vector3 forceVector ;

    private void OnCollisionEnter(Collision other)
    {
        forceVector.y = force;
        rigidBodyObj.AddForce(forceVector);
    }

    private void Start()
    {
        rigidBodyObj = GetComponent<Rigidbody>();
    }
}
