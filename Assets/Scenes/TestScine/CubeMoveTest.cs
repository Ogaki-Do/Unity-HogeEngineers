using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoveTest : MonoBehaviour {
    [SerializeField] GameObject ArrowPuls;
    [SerializeField] GameObject ArrowMinus;
    [SerializeField]Vector2 mousemove;
    [SerializeField] Transform cameratrans;
    Vector3 test;
    bool pulsdebug;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        mousemove.x = Input.GetAxis("Mouse X");   //マウス加速度取得
        mousemove.y = Input.GetAxis("Mouse Y");   //マウス加速度取得
        if (pulsdebug) {
            //カメラの向きベクトルとマウス加速度を合成カメラ自体の移動ベクトルを算出
            test = cameratrans.right * mousemove.x;
            test += cameratrans.up * mousemove.y;
            this.transform.position += new Vector3(0, 0, test.z);
        }
    }
    public void PlusBigin() {
        pulsdebug = true;
    }
    public void PlusEnd() {
        pulsdebug = false;
    }
}
