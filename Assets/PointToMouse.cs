using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToMouse : MonoBehaviour
{
  
    void FixedUpdate()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        transform.position += (Camera.main.ScreenToWorldPoint(mousePos)-transform.position)/10;
    }  
    
    
}
