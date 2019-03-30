using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTachChecer : MonoBehaviour
{
    [SerializeField] public bool Tach;
    [SerializeField] float TachThreshold_Y;
    [SerializeField] Vector3 hitpos = Vector3.zero;//接地点

    public void OnCollisionStay(Collision collision) {
        foreach (ContactPoint point in collision.contacts) {
            hitpos = transform.InverseTransformPoint(point.point);
        }
        //当たり判定条件設定
        if (hitpos.y < TachThreshold_Y)
            Tach = true;
        else
            Tach = false;
    }
    public void OnCollisionExit(Collision collision) {
        Tach = false;
    }
}
