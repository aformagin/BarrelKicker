using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastShooting : MonoBehaviour {

    void Start(){}
    void Update(){
        //TODO - Make it so it sends a raycast all the time to find the distance of the barrel from the user for prompting
        Ray ray = new Ray(transform.position, transform.TransformDirection(Vector3.forward));
        RaycastHit hitInfo;
        Physics.Raycast(ray, out hitInfo);
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitInfo.distance, Color.red);


        if(Input.GetButtonDown("Fire1")){
            //If the ray collides with a barrel - Move barrel
             Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitInfo.distance, Color.blue);

            if(hitInfo.collider.tag.Equals("Barrel")){

                if(hitInfo.distance <= 3.0f){
                    Debug.Log("Hit Barrel");
                    hitInfo.collider.attachedRigidbody.AddForce(
                        transform.forward * 2.0f + transform.up * 2.5f, //Force is half of 1 unit vector forward, and 1 unit vector up
                        ForceMode.Impulse);
                }
                    
            }
        }
    }
        //TODO - Check for a a GBD for Interact - Then move the above into it
        
        
}