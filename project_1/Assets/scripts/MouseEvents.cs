using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{
    public UnityEvent mouseDownEvent;
    public UnityEvent mouseDragEvent;
    public UnityEvent mouseEnterEvent;
    public UnityEvent mouseOverEvent;
    public UnityEvent mouseExitEvent;
    public UnityEvent mouseUpEvent;
    public UnityEvent moveBlock;
    private void OnMouseDown()
    {
    mouseDownEvent.Invoke();
    }

    private void OnMouseDrag()
    {
      mouseDragEvent.Invoke();
    }

    private void OnMouseEnter()
    {
        mouseEnterEvent.Invoke();
    }

    private void OnMouseOver()
    {
        mouseOverEvent.Invoke();
    }

    private void OnMouseExit()
    {
        mouseExitEvent.Invoke();
    }

    private void OnMouseUp()
    {
      mouseUpEvent.Invoke();  
    }

    private void OnAnimatorMove()
    {
     moveBlock.Invoke();   
    }
}
