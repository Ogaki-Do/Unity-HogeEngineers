using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YazirusiMoveTest : MonoBehaviour {
    [SerializeField]
    GameObject YazirusiObject;
    GameObject Yazirusi;
    [SerializeField, Range(-0.1f, 0.1f)]
    float Moveimput;
    [SerializeField]
    float Move;
	// Use this for initialization
	void Start () {
		Yazirusi = Instantiate(YazirusiObject) as GameObject;
    }
	
	// Update is called once per frame
	void Update () {
        Move += Moveimput;
        if (Mathf.Abs(Move) >= 1) {
            Yazirusi.transform.position += Yazirusi.transform.forward*Move/ Mathf.Abs(Move);
            Move = 0;
        }
    }
}
