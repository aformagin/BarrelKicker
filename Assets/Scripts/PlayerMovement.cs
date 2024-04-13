using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TODO
public class PlayerMovement : MonoBehaviour
{
    Rigidbody _rb;
    Vector3 _direction;
    float hInput, vInput;
    public Transform orientation;
    public float moveSpeed;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.freezeRotation = true;
    }
    void Update()
    {
        PlayerInput();
    }

    void FixedUpdate(){
        MovePlayer();
    }

    void PlayerInput(){
        hInput = Input.GetAxisRaw("Horizontal");
        vInput = Input.GetAxisRaw("Vertical");
    }

    void MovePlayer(){
        _direction = orientation.forward * vInput + orientation.right * hInput;
        _rb.AddForce(_direction.normalized * moveSpeed * 10f, ForceMode.Force);
    }

}