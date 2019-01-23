using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipContllerTest : MonoBehaviour {
    public Vector3 WontGO=Vector3.zero;
    Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
        rigidbody = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate(){
        WontGO = rigidbody.velocity *0.1f;
    }
}
