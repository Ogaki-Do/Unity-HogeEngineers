using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddforceAtPostionTest : MonoBehaviour {
    [SerializeField,Range(0,20)]
    float pow;
    Rigidbody thisrig;
	// Use this for initialization
	void Start () {
        //親のリジットｂｏｄｙを取得
        thisrig = this.transform.parent.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        //親のリジッドｂｏｄｙに自分の座標から自分の進行方向に推進力を与える
        thisrig.AddForceAtPosition(this.transform.forward*pow*-1, this.transform.position);
    }
}
