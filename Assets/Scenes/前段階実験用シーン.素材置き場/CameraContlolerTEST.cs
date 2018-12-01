using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContlolerTEST : MonoBehaviour {
    [SerializeField]
    public Vector3 Center;//カメラの見ている先
    Transform Thistrans;//その名の通り

    [SerializeField]
    bool CamMove=false;//カメラが移動したときtrue
	// Use this for initialization
	void Start () {
        //各種初期化取得
        Thistrans = this.transform;
        Center = new Vector3(0, 0, 0);

	}
	
	// Update is called once per frame
	void Update () {
        if (CamMove) {
            Thistrans.LookAt(Center);
        }
	}
}
