using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigidbodytest : MonoBehaviour
{
    Rigidbody thisrig;
    [SerializeField] Vector3 Velocity;
    [SerializeField] bool Do=false;
    [SerializeField] float pow;
    // Start is called before the first frame update
    void Start() {
        thisrig = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
        if (Do) {
            thisrig.AddForce(Vector3.up * pow, ForceMode.VelocityChange);
            Do = false;
        }
    }
    private void FixedUpdate() {
        Velocity = thisrig.velocity;
    }
}
