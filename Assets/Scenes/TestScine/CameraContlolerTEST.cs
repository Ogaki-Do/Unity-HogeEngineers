using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CameraContlolerTEST : MonoBehaviour {
    [SerializeField]
    public Vector3 Center;//カメラの見ている先
    Transform Thistrans;//その名の通り

    [SerializeField]
    bool CamMove=true;//カメラが移動したときtrue
    [SerializeField]
    bool wheel;

    [SerializeField]
    Vector2 rotatespeed;
    [SerializeField]
    Vector2 HorizonMove;
    [SerializeField]
    Vector2 HorizonMovespeed;
	// Use this for initialization
	void Start () {
        //各種初期化取得
        Thistrans = this.transform;
        Center = new Vector3(0, 0, 0);




    }
	
	// Update is called once per frame
	void Update () {
        //指定座標の注視
        if (CamMove) {
            Thistrans.LookAt(Center);
        }

        //回転処理
        if (Input.GetMouseButton(0)) {
            rotatespeed.x =Input.GetAxis("Mouse X");    //マウス加速度取得
            rotatespeed.y = Input.GetAxis("Mouse Y")*(-1);   //マウス加速度取得
            rotatespeed *= 2;//速度調整
            Thistrans.RotateAround(Center, new Vector3(0, 1, 0), rotatespeed.x);//回転
            Thistrans.RotateAround(Center, Thistrans.right, rotatespeed.y);     //回転
             
        }
        //カメラ移動
        if (Input.GetMouseButton(1)) {
            HorizonMove.x = Input.GetAxis("Mouse X")*HorizonMovespeed.x;
            HorizonMove.y = Input.GetAxis("Mouse Y")*HorizonMovespeed.y;
            Center -= Thistrans.right * HorizonMove.x;
            Thistrans.position -= Thistrans.right * HorizonMove.x;
            Center -= new Vector3(0, 1, 0) * HorizonMove.y;
            Thistrans.position -= new Vector3(0, 1, 0) * HorizonMove.y;
        }
        if (wheel) {
            Thistrans.transform.position+=Thistrans.forward*Input.GetAxis("Mouse ScrollWheel");
            //this.GetComponent<Camera>().orthographicSize -= Input.GetAxis("Mouse ScrollWheel");//並行投影時用
        }

            
	}
}
