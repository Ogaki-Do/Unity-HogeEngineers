using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrusterTestScript : MonoBehaviour {
    Rigidbody ThisRig;
    [SerializeField,Range(0,2000)]public float Power;
    BrockDataTest Mydata;
    ShipContllerTest ShipContller;
    [SerializeField]bool OverRide;
	// Use this for initialization
	void Start () {
        if (this.transform.parent != null) {
            ThisRig = this.transform.parent.GetComponent<Rigidbody>();
        } else
            ThisRig = this.GetComponent<Rigidbody>();
        ShipContller = this.transform.parent.GetComponent<ShipContllerTest>();

        Mydata = new BrockDataTest(ThisRig);

        Mydata.TogleUseGravity(false);
    }
	
	// Update is called once per frame
	void Update () {
    }

    public void togletest(){
        Mydata.TogleUseGravity();
    }

    private void FixedUpdate(){
        if (OverRide == false) {
            Power = Vector3.Dot(ShipContller.WontGO, this.transform.forward);
        }




        ThisRig.AddForceAtPosition(this.transform.forward * Power * -1, this.transform.position);
    }

}
