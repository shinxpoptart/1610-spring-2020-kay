using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Image = UnityEngine.Experimental.UIElements.Image;

[RequireComponent(typeof(Image))]

public class ImageBehavior : MonoBehaviour
{
    private Image imageObj;
    // Start is called before the first frame update
    void Start()
    {
        imageObj = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
