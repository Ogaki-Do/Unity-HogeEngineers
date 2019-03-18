using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRoomEditor : MonoBehaviour {
    [SerializeField,Range(0,3)] uint Mode;//移動　回転　拡縮　非選択
    [SerializeField]GameObject Turget;
   [SerializeField] GameObject[] Yazirusi = new GameObject[6];

    Vector3Int Prus;
    Vector3Int Minus;

    [SerializeField] GameObject YazirusiPrefab;
    //拡縮選択時処理
    void BeginSizeChange() {
        for (int i = 0; i < 6; i++) {
            Yazirusi[i] = Instantiate(YazirusiPrefab) as GameObject;
            Yazirusi[i].transform.position = Turget.transform.position;
        }

        Yazirusi[0].transform.rotation = new Quaternion(0, 1, 0, -1);
        Yazirusi[1].transform.rotation = new Quaternion(1, 0, 0, 1);
        Yazirusi[2].transform.rotation = new Quaternion(0, 1, 0, 0);
        Yazirusi[3].transform.rotation = new Quaternion(0, 1, 0, 1);
        Yazirusi[4].transform.rotation = new Quaternion(0, 1, 1, 0);
        Yazirusi[5].transform.rotation = new Quaternion(0, 0, 0, 0);
    }
	// Use this for initialization
	void Start () {
        BeginSizeChange();

    }


	
	// Update is called once per frame
	void Update () {
		
	}
}
