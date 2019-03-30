using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharactorControlSetings {
    public GameObject Body;
    public GameObject head;//頭(このポジにカメラを持ってくる)
    public GameObject chest;//胴
    public GroundTachChecer GroundTachChecer;//接地判定スクリプト
    public float Walkspeed;//歩行速度
    public float dashspeed;//ダッシュ速度
    public float squatspeed;//しゃがみ時のスピード
    public float fallingspeed;//落下中の空中でのスピード
    public float Jumppow;//ジャンプ時のパワー
    public float Rotatespeed;//旋回速度
}

public class CharactorControler : MonoBehaviour {
    [SerializeField]public CharactorControlSetings SetingData;//初期設定
    //接地判定の結果
    [SerializeField]float Gravity;//重力[m/s]
    [SerializeField] bool  Tach;//接地判定
    //操作反映の可否
    [SerializeField] bool MoveEnible ;
    Vector2 Inputmove, InputRotation, Outputpostion, Outputmove;
    bool Dojump;
    bool Dodash;
    bool DoSquat;
    bool Move;
    Rigidbody OutputRig;
    int testInt=0;
    

    [SerializeField] bool test;
    // Use this for initialization
    void Start() {
        OutputRig = SetingData.Body.GetComponent<Rigidbody>();// SetingData.Body.GetComponent<Rigidbody>();
        SetingData.GroundTachChecer = SetingData.Body.GetComponent<GroundTachChecer>();
    }

    // Update is called once per frame
    void Update() {
        //入力受付
        Inputmove = new Vector2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal")).normalized;
        InputRotation = new Vector2(Input.GetAxis("Mouse Y")*-1, Input.GetAxis("Mouse X"));
        Dojump = (Input.GetAxis("Jump") == 1);
        Dodash = (Input.GetAxis("Dash") == 1);
        DoSquat = (Input.GetAxis("Squat") == 1);
        
        //入力の有無
        Move = (Inputmove != new Vector2(0, 0) || Dojump)&&MoveEnible;
        //回転操作
        if (MoveEnible) {
            //横回転スクリプト
            SetingData.Body.transform.Rotate(new Vector3(0, InputRotation.y * SetingData.Rotatespeed, 0));
            SetingData.chest.transform.Rotate(new Vector3(InputRotation.x * SetingData.Rotatespeed, 0, 0));
            //回転角度制限スクリプト
            if (SetingData.chest.transform.localRotation.eulerAngles.y == 180)
                SetingData.chest.transform.Rotate(new Vector3(InputRotation.x * SetingData.Rotatespeed * -1, 0, 0));
        }
    }

    void LateUpdate() {
        //カメラ固定
        if (MoveEnible) {
            this.transform.position = SetingData.head.transform.position;
            this.transform.rotation = SetingData.head.transform.rotation;
        }
    }

    void FixedUpdate() {
        Tach = SetingData.GroundTachChecer.Tach;
        if (Move) {
            if (Tach) {
                //ジャンプする
                if (Dojump) {
                    Dojump = false;
                    OutputRig.AddForce(Vector3.up * Mathf.Sqrt(SetingData.Jumppow*2*Gravity)/2, ForceMode.VelocityChange);
                    Debug.Log( "Jump/r"+testInt++);
                }Dojump = false;
                //移動の掛け算
                if (Dodash)
                    Outputmove = Inputmove * SetingData.dashspeed;
                else if (DoSquat)
                    Outputmove = Inputmove * SetingData.squatspeed;
                else
                    Outputmove = Inputmove * SetingData.Walkspeed;
                
            } 
            else {
                //ジャンプするだけのに必要
                Dojump = false;


                //移動の掛け算
                Outputmove = Inputmove * SetingData.fallingspeed;
            }
        }
        else {
            Outputmove = Vector2.zero;
        }

        if (Tach) {
            Vector3 outputpow = SetingData.Body.transform.forward * Outputmove.x + SetingData.Body.transform.right * Outputmove.y;
            outputpow.y = OutputRig.velocity.y;
            OutputRig.velocity = outputpow;
            //new Vector3( Outputmove.x,OutputRig.velocity.y,Outputmove.y)
            test = false;
        } else if (!(Tach) && test) {
            test = true;
            OutputRig.AddForce(SetingData.Body.transform.forward * Outputmove.x, ForceMode.VelocityChange - 1);
            OutputRig.AddForce(SetingData.Body.transform.right * Outputmove.y, ForceMode.VelocityChange - 1);
        } else {
            test = true;
            OutputRig.AddForce(SetingData.Body.transform.forward * Outputmove.x, ForceMode.VelocityChange);
            OutputRig.AddForce(SetingData.Body.transform.right * Outputmove.y, ForceMode.VelocityChange);
        }


    }


 
}
