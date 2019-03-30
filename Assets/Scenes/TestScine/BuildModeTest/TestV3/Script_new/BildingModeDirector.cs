using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BildingModeDirector : MonoBehaviour {
    [SerializeField] public List<GameObject> BrockGraphic; //ブロックのグラリスト
    [SerializeField] public List<GameObject> Brocks;       //保存してるブロックのリスト
    [SerializeField] GameObject BrockPrefab;//生成するブロックのプレハブ

    private Ray ray;
    private RaycastHit raycastHit;

    [SerializeField, Range(0, 5), SpaceAttribute] public int ContlolMode = 0;
    //0 閲覧 何もできない
    //1 設置 設置後拡縮にモードが変更される
    //2 移動 ブロックのを移動させられる
    //3 拡縮 ブロックのサイズ変更を行う
    //4 回転 ブロックの回転を行う
    //5 削除 ブロックの削除を行う
    [SerializeField] bool Click;
    [SerializeField] Vector3 InputMousAcceleration;　//マウスの移動量









    public GameObject SerchBrockGraphic(string form) {
        GameObject Graphic = null;
        for (int num1 = 0; num1 < BrockGraphic.Count; num1++) {
            if (BrockGraphic[num1].name == form) {
                Graphic = BrockGraphic[num1];
                Debug.Log(BrockGraphic[num1].name + "num1%d" + num1);
                break;
            }
        }
        return Graphic;
    }
    //ブロックの生成
    
    
    private void CriateBrock(string brockform, Vector3 pulspostion) {
        //GameObjectの生成
        GameObject NewBrock = Instantiate(BrockPrefab);
        //初期化メゾットの実行
        NewBrock.GetComponent<BildingmodeBrock>().StartBrock(
            brockform, pulspostion, pulspostion - Vector3.one, 
            this.gameObject, new Quaternion(0, 0, 0, 0));
        //リストに追加
        Brocks.Add(NewBrock);
    }

    //Ray飛ばすマン
    private bool GetReyHit() {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        raycastHit = new RaycastHit();

        //例
        //当たったかどうか(bool)
        //Physics.Raycast(ray, out raycastHit)
        //当たった座標
        //raycastHit.point
        //当たった面の法線ベクトル
        //raycastHit.normal

        return Physics.Raycast(ray, out raycastHit);

    }

    //マウス加速度をvec3に変換する
    public Vector3 MouseAxiz3D (Vector2 MouseAxiz) {
        Vector3 mousepos = Input.mousePosition;
        mousepos.z = raycastHit.distance;
        Vector3 Output = Camera.main.ScreenToWorldPoint(mousepos);
        mousepos.x -= MouseAxiz.x;   //マウス加速度取得
        mousepos.y -= MouseAxiz.y;
        Output -= Camera.main.ScreenToViewportPoint(mousepos);
        return Output;
    }

    private void OnclickMove(GameObject Turget) {
        if (GetReyHit()) {
            switch (ContlolMode) {
                //閲覧モード
                case 0:
                    break;
                //設置モード
                case 1:

                    break;
                //移動モード
                case 2:
                    break;
                //拡縮モード
                case 3:
                    break;
                //回転モード
                case 4:
                    break;
                //削除モード
                case 5:
                    break;
            }

        }
    }


    // Start is called before the first frame update
    void Start() {

        Click = Input.GetMouseButton(0);
        

    }

    // Update is called once per frame
    void Update() {

    }
}
