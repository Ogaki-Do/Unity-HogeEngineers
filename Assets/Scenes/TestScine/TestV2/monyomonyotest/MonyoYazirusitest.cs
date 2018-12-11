using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonyoYazirusitest : MonoBehaviour {
    bool Drag;
    Transform Camera;
    Vector2 MouseMove;
    Vector3 MouseMoveVectol3D;

    private void Start()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }
    // Update is called once per frame
    void Update()
    {
        MouseMove.x = Input.GetAxis("Mouse X");   //マウス加速度取得
        MouseMove.y = Input.GetAxis("Mouse Y");   //マウス加速度取得
        if (Drag){
            MouseMoveVectol3D = Draging(Camera, MouseMove);
            this.transform.position += this.transform.forward * Vector3.Dot(MouseMoveVectol3D, this.transform.forward);
        }
        else
            MouseMoveVectol3D = new Vector3(0, 0, 0);
    }




    //マウス入力を３次元に変換
    public Vector3 Draging(Transform camera, Vector2 MouseMove){
        Vector3 OutAddTransform = Vector3.zero;
            OutAddTransform = camera.right * MouseMove.x;
            OutAddTransform += camera.up * MouseMove.y;
        return /*Vector3.Normalize(*/OutAddTransform;
    }




    //ドラッグされてるか確認
    public void BeginDrag()
    {
        if (Input.GetMouseButton(0))
            Drag = true;
    }
    public void EndDrag()
    {
        Drag = false;
    }
}
