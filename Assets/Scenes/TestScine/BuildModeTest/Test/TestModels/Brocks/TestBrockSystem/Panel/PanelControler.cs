using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelControler : MonoBehaviour {
    bool Drag;
    [SerializeField] Transform Camera;
    Vector2 MouseMove;
    [SerializeField]Vector3 MouseMoveVectol3D;
    

    [SerializeField] Vector3 test;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MouseMove.x = Input.GetAxis("Mouse X");   //マウス加速度取得
        MouseMove.y = Input.GetAxis("Mouse Y");   //マウス加速度取得

        test=Camera.forward;

        if (Drag) {
            MouseMoveVectol3D = Draging(Camera, MouseMove);
            this.transform.position += this.transform.forward*Vector3.Dot(MouseMoveVectol3D, this.transform.forward);
        }
        else {
            MouseMoveVectol3D =new Vector3(0, 0, 0);
        }
	}




    //マウス入力を３次元に変換
    public Vector3 Draging(Transform camera, Vector2 MouseMove) {
        Vector3 OutAddTransform=Vector3.zero;
        if (Input.GetMouseButton(0)){
            OutAddTransform = camera.right * MouseMove.x;
            OutAddTransform += camera.up * MouseMove.y;
        }
        return Vector3.Normalize(OutAddTransform)*0.05f;
    }




    //ドラッグされてるか確認
    public void BeginDrag(){
        Drag = true;
    }
    public void EndDrag(){
        Drag = false;
    }
}
