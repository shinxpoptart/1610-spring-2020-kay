using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
[RequireComponent(typeof(MeshRenderer))]
public class colorChange : MonoBehaviour

{
    public Renderer cubeColor;
    public Material startShader ;
    // using tutorial https://youtu.be/Z0Z7xc18CcA
    void Start()
    {
        cubeColor = GetComponent<Renderer>();
        cubeColor.material = startShader;


    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer> ().material.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            GetComponent<Renderer> ().material.color = Color.clear;
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            Destroy(gameObject);
        }
    }
}
