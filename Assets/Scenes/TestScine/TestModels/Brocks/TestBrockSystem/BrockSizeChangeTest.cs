using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrockSizeChangeTest : MonoBehaviour {
    [SerializeField] public bool enaible;
    [SerializeField] GameObject[] Panel = new GameObject[6];
    TestQuadControler[] PanelTestQuadControler = new TestQuadControler[6];
    [SerializeField, Range(0, 5)]int ChoiseSide;
    //0->+x
    //1->+y
    //2->+z
    //3->-z
    //4->-y
    //5->-x
    [SerializeField] Material[] material = new Material[2];
    [SerializeField]
    GameObject Camera;
    BoxCollider BoxCollider;
    // Use this for initialization
    void Start () {
        for (int i = 0; i < 6; i++)
            PanelTestQuadControler[i]= Panel[i].GetComponent<TestQuadControler>();
        BoxCollider = this.GetComponent<BoxCollider>();
}
	
	// Update is called once per frame
	void Update () {
        
	}
    public void TogleSwich(bool a) {
        enaible = a;
        BoxCollider.enabled = (a==false);
        if (enaible) {
            for (int i = 0; i < 6; i++)
                PanelTestQuadControler[i].MeshRenderer.material = material[1];
        }
        else {
            for (int i = 0; i < 6; i++)
                PanelTestQuadControler[i].MeshRenderer.material = material[0];
        }
    }
}
