using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    float mouseX;
    float mouseY;
    public bool inversionMouse;

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mouseX += Input.GetAxis("Mouse X");
        if (inversionMouse)
        {
            mouseY += Input.GetAxis("Mouse Y");

        }
        else
        {
            mouseY -= Input.GetAxis("Mouse Y");
        }
        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
    }
}
