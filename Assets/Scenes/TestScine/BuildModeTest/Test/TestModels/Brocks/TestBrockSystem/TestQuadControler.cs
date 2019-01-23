using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestQuadControler : MonoBehaviour {
    BrockSizeChangeTest ParentCon;
    [SerializeField] GameObject Sphere;
    public MeshRenderer MeshRenderer;
    SphereCollider SphereCollider;
	// Use this for initialization
	void Start () {
        ParentCon = this.transform.parent.GetComponent<BrockSizeChangeTest>();
        Sphere = this.transform.Find("Sphere").gameObject;
        MeshRenderer = this.GetComponent<MeshRenderer>();
        SphereCollider = this.GetComponent<SphereCollider>();
	}
	
	// Update is called once per frame
	void Update () {
        //Sphere.SetActive(ParentCon.enaible);
        //SphereCollider.enabled = ParentCon.enaible;

    }
}
