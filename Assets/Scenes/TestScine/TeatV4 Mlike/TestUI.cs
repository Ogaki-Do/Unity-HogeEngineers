using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestUI : MonoBehaviour
{
    [SerializeField] GameObject Turget;
    Text test;
    // Start is called before the first frame update
    void Start(){
        test = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update(){
        test.text = "\r\n"+Turget.transform.position.y;
    }
}
