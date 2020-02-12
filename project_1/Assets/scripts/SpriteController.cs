using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteController))]

public class SpriteController : MonoBehaviour
{
    public Color offColor = Color.red;
    public Color thisColor = Color.green;
    private SpriteRenderer spriteObj;

    // Start is called before the first frame update
    void Start()
    {
        spriteObj = GetComponent<SpriteRenderer>();
        spriteObj.color = thisColor;
    }

    private void OnEnable() //when an item is enabled
    {
        spriteObj.color = thisColor;
    }

    private void OnDisable() //when an item is disabled
    {
        spriteObj.color = offColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
