using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;//インスペクタを改造するマン

//[CustomEditor(typeof(Inspectortest/*ここは自分のクラス名*/))]
public class Inspectortest : MonoBehaviour {
    [SerializeField]
    int[] a;
    [SerializeField]
    Color b;
    [SerializeField, Range(0, 10)]
    int c;
    [SerializeField, Tooltip("解説")]
    int d;
    [SerializeField, Multiline(4)]
    string e;


    //ここからUnityEditor必須な
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
