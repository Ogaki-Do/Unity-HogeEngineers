using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRoomData : MonoBehaviour {
    //データ本体
    [SerializeField]public uint RoomModel;      //モデルや計算のベース
    [SerializeField] public Vector3Int RoomSize;//部屋自体のサイズ
    [SerializeField] public Vector3 Postion;    //部屋の座標


    //部屋のデータ初期化
    public TestRoomData(uint RoomModelNumber, Vector3 postion) {
        RoomModel = RoomModelNumber;
        RoomSize = Vector3Int.one;
        Postion = postion;
    }

    public void UpdatRoomData () {
        this.transform.position = Postion;
        this.transform.localScale = RoomSize;
    }

    public void CalculationRoomData(Vector3Int Puls,Vector3Int Minus) {
        Postion = (Vector3)( Puls - Minus)/ 2 + Minus;
        RoomSize = Puls - Minus;
        UpdatRoomData();
    }


    //デバッグ用
    [SerializeField] bool debug = false;
    private void Update() {
        if (debug) {
            UpdatRoomData();
            debug = false;
        }
    }
}
