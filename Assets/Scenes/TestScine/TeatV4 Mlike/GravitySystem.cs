using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySystem : MonoBehaviour
{
    [SerializeField] float Gravity;//[重力[m/s]
    Rigidbody ThisRig;
    // Start is called before the first frame update
    void Start(){
        ThisRig = this.GetComponent<Rigidbody>();
    }
    private void FixedUpdate() {
        ThisRig.AddForce(Vector3.down * Gravity* 0.01666667f, ForceMode.VelocityChange);
    }

}
