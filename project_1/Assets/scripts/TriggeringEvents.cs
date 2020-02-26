using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggeringEvents : MonoBehaviour
{
    public int Tester;
    public float Floater;
    public string String;
    public UnityEvent enter;
    public UnityEvent stay;
    public UnityEvent exit;

    private void OnTriggerEnter(Collider other)
    {
    enter.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        stay.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        exit.Invoke();
    }
}

