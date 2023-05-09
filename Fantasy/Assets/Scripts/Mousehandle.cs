using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousehandle : MonoBehaviour
{
    private float yRotation = 0;
    private float xRotation = 0;
    private float horizontalSpeed = 5;
    private float verticalSpeed = 5;
    private Camera Cam;
    // Start is called before the first frame update
    void Start()
    {
        Cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * horizontalSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * verticalSpeed;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation,-90,90);

        Cam.transform.eulerAngles = new Vector3(xRotation, yRotation, 0);
    }
}
