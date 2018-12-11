using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MonyoMonyotest : MonoBehaviour {
    const int Xpuls = 0;
    //0->+x
    const int Ypuls = 1;
    //1->+y
    const int Zpuls = 2;
    //2->+z
    const int Zminus = 3;
    //3->-z
    const int Yminus = 4;
    //4->-y
    const int Xminus = 5;
    //5->-x

    [SerializeField]GameObject YazirusiPrefab ;
    GameObject[] Yazirusi = new GameObject[6];

    // Use this for initialization
    int i;
    void Start () {
        Vector3 postion=Vector3.zero;
        for (i = 0; i < 6; i++){
            Yazirusi[i] = Instantiate(YazirusiPrefab) as GameObject;
        }
        Yazirusi[Xpuls].transform.position = this.transform.forward * 1.25f;
        Yazirusi[Xminus].transform.position = this.transform.forward * -1.25f;
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
