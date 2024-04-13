using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float _sensX, _sensY;
    float xRotation, yRotation;
    public Transform _orientation;
    public Camera _fpsCamera;
    // Start is called before the first frame update
    void Start()
    {
        //Setting initial position and rotation of camera
        _fpsCamera.transform.position = this.gameObject.transform.position;
        _fpsCamera.transform.rotation = this.gameObject.transform.rotation;

        //Locking cursor to screen
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 initVec = this.transform.position;
        Vector3 _camPostion = new Vector3(initVec.x,initVec.y + 0.5f,initVec.z);
        _fpsCamera.transform.position = _camPostion;

        //mX is the MouseX, mY is MouseY
        float mX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * _sensX;
        float mY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * _sensY;

        yRotation += mX;
        xRotation -= mY;
        //Clamp the X rotation so that you can never flip around
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        //Setting camera rotation
        _fpsCamera.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);

        //Setting player object rotation
        _orientation.rotation = Quaternion.Euler(0, yRotation, 0);
        transform.rotation = _orientation.rotation;
    }

}
