using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YazirusiMoveMouseTest : MonoBehaviour {
    bool Drag;
    Transform Camera;
    Vector2 MouseMove;
    Vector3 MouseMoveVectol3D;
    [SerializeField]float DragMove;

    private void Start() {
        Camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }
    // Update is called once per frame
    void Update() {
        MouseMove.x = Input.GetAxis("Mouse X");   //マウス加速度取得
        MouseMove.y = Input.GetAxis("Mouse Y");   //マウス加速度取得
        if (Drag) {
            MouseMoveVectol3D = Draging(Camera, MouseMove);
            DragMove += Vector3.Dot(MouseMoveVectol3D, this.transform.forward);
            if (Mathf.Abs(DragMove) >= 1) {
                this.transform.position += this.transform.forward * DragMove / Mathf.Abs(DragMove);
                DragMove = 0;
            }

        } else {
            DragMove = 0;
            MouseMoveVectol3D = new Vector3(0, 0, 0);
        }
    }




    //マウス入力を３次元に変換
    public Vector3 Draging(Transform camera, Vector2 MouseMove) {
        Vector3 OutAddTransform = Vector3.zero;
        OutAddTransform = camera.right * MouseMove.x;
        OutAddTransform += camera.up * MouseMove.y;
        return /*Vector3.Normalize(*/OutAddTransform;
    }




    //ドラッグされてるか確認
    public void BeginDrag() {
        Debug.Log("Begin");
        if (Input.GetMouseButton(0))
            Drag = true;
    }
    public void EndDrag() {
        Debug.Log("end");
        Drag = false;
    }
}
