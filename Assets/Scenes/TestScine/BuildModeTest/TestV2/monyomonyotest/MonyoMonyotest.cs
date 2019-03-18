using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MonyoMonyotest : MonoBehaviour {
    const int Xpuls = 0;
    //0->+x
    const int Zminus = 1;
    //1->-z
    const int Xminus = 2;
    //2->+z
    const int Zpuls = 3;
    //3->-z
    const int Yminus = 4;
    //4->-y
    const int Ypuls = 5;
    //5->-x

    [SerializeField]GameObject YazirusiPrefab ;
    [SerializeField] GameObject[] Yazirusi = new GameObject[6];

    // Use this for initialization
    int i;
    void Start () {
        Vector3 yazirusi=Vector3.zero;
        Vector3 postion=Vector3.zero;
        for (i = 0; i < 6; i++){
            Yazirusi[i] = Instantiate(YazirusiPrefab) as GameObject;
            //Yazirusi[i].transform.parent = this.transform;
            Yazirusi[i].transform.position = this.transform.position;
            if (i <= 3)
                yazirusi += new Vector3(0f, 90f, 0f);
            else if (i == 4)
                yazirusi = new Vector3(90f, 0, 0);
            else
                yazirusi= new Vector3(-90f, 0, 0);
            Yazirusi[i].transform.Rotate(yazirusi);
            Yazirusi[i].transform.position -= Yazirusi[i].transform.forward*(0.5f) ;
        }
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 postion = new Vector3(
            ((int)Yazirusi[Xpuls].transform.position.x + (int)Yazirusi[Xminus].transform.position.x) / 2,
            ((int)Yazirusi[Ypuls].transform.position.y + (int)Yazirusi[Yminus].transform.position.y) / 2,
            ((int)Yazirusi[Zpuls].transform.position.z + (int)Yazirusi[Zminus].transform.position.z) / 2);
        Vector3 scale = new Vector3(
           (int)(Yazirusi[Xpuls].transform.position.x - Yazirusi[Xminus].transform.position.x),
           (int)(Yazirusi[Ypuls].transform.position.y - Yazirusi[Yminus].transform.position.y),
           (int)(Yazirusi[Zpuls].transform.position.z - Yazirusi[Zminus].transform.position.z));
        this.transform.position = postion;
        this.transform.localScale = scale;
	}
}
