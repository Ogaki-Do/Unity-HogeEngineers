using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BrockSizeChangeTest : MonoBehaviour {
    [SerializeField] GameObject[] Panel = new GameObject[6];
    [SerializeField, Range(0, 5)]int ChoiseSide;
    //0->+x
    //1->+y
    //2->+z
    //3->-z
    //4->-y
    //5->-x
    [SerializeField]
    GameObject Camera;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
