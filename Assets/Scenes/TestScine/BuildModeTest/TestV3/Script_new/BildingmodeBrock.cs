using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BildingmodeBrock : MonoBehaviour{
    //↓保存しない↓
    [SerializeField] public GameObject BildingDirector;//ディレクターにつながる
    //ブロック描写用の子
    [SerializeField] GameObject BrockGraphic;
    //[SerializeField] BoxCollider ThisColoder;


    //↓保存する↓
    [SerializeField] public string BrockForm; //ブロックの形　これをもとにディレクターから検索する
    //ブロックの対角線上の2点の座標
    [SerializeField] public Vector3 PulsPostion = Vector3Int.zero;//原点から全要素が＋側にある
    [SerializeField] public Vector3 MinusPostion= Vector3Int.one;//原点から全要素が-側にある
    //ブロックの回転
    [SerializeField] public Quaternion BrockRotation;//ブロックの回転状態

    //-----------------------------------------------------------
    
    //このオブジェクトの初期化系(Startにしないのタイミングを任意にするため)
    public void StartBrock(string brockform, Vector3 pulspos, Vector3 minuspos, GameObject Director ,Quaternion rotation) {
        BrockForm = brockform;
        BildingDirector = Director;

        PulsPostion = pulspos;
        MinusPostion = minuspos;
        BrockRotation = rotation;

        //グラフィックの召喚
        BrockGraphic = Director.GetComponent<BildingModeDirector>().SerchBrockGraphic(BrockForm);
        if (BrockForm == null) {
            //エラったらここで終わるよーん
            Debug.Log("BrockFormNameErroe", this.gameObject);
            Destroy(this.gameObject);
            return ;
        }
        //
        BrockGraphic = Instantiate(BrockGraphic);
        BrockGraphic.transform.parent = this.transform;
        BrockGraphic.transform.localRotation = BrockRotation;
        BrockGraphic.transform.localPosition = Vector3.zero;



        UpdateBurockGraphic();

        return ;
    }

    //ブロックの外見を更新する
    public void UpdateBurockGraphic() {
        //座標更新
        this.transform.position = (Vector3)(PulsPostion + MinusPostion)/2;
        //サイズ更新
        this.transform.localScale = (PulsPostion - MinusPostion);
        //ThisColoder.size = (PulsPostion - MinusPostion);
        //回転の更新
        BrockRotation = BrockGraphic.transform.rotation;
    }
    //サイズの変更　RayのNormalからどの面を押されてるか判断しサイズを変更する
    public void SizeChange (Vector3 normal ,Vector3 amount) {
        Vector3 TestPuls=PulsPostion;
        Vector3 TestMinus=MinusPostion;
        if (Vector3.Dot(Vector3.one, normal) > 0)
            TestPuls += amount;
        else
            TestMinus += amount;
        if (((TestPuls[0] - TestMinus[0] > 0) && (TestPuls[1] - TestMinus[1] > 0)) && (TestPuls[2] - TestMinus[2] > 0)) {
            PulsPostion = TestPuls;
            MinusPostion = TestMinus;
        } else
            return;
        
    }

    //移動用スクリプト　amountだけ移動させる
    public void MovePostion (Vector3 amount) {
        PulsPostion += amount;
        MinusPostion += amount;
    }

    //回転用スクリプト
    public void Rotate (Vector3 amount) {
        BrockGraphic.transform.Rotate(amount);
    }
    //public void 


}
