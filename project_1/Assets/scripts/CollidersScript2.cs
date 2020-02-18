using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidersScript2 : MonoBehaviour
{
    //tutorial: https://www.youtube.com/watch?v=bh9ArKrPY8w

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entering...");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("staying...");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exiting...");   
    }
}
