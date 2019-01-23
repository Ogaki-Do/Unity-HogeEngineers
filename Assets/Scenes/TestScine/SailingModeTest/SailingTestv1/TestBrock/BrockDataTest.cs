using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrockDataTest : MonoBehaviour {
    [SerializeField] Rigidbody ThisRigitBody;
    [SerializeField] Color ThisColor;
    public BrockDataTest(Rigidbody rigidbody){
        ThisRigitBody = rigidbody;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TogleUseGravity (bool? use=null){
        if (use == null)
            ThisRigitBody.useGravity = (ThisRigitBody.useGravity == false);
        else
            ThisRigitBody.useGravity = (use==true);

    }
}
