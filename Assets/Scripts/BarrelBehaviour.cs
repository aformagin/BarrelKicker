using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelBehaviour : MonoBehaviour{
    private Vector3 _initLocation;
    private Quaternion _initRotation;
    void Start(){
        _initLocation = this.transform.position;
        _initRotation = this.transform.rotation;

    }
    void Update(){
        
    }

    private void OnTriggerEnter(Collider c){
        if(c.isTrigger && c.gameObject.CompareTag("Goal")){
            Debug.Log("Scored!");
            //TODO - Destroy and respawn the object
            // this.transform.position = _initLocation;
            // this.transform.rotation = _initRotation;
            // this.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        }
    }
}