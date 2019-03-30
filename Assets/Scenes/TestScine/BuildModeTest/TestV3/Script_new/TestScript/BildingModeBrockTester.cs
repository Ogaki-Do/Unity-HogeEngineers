using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BildingModeBrockTester : MonoBehaviour
{
    [SerializeField, SpaceAttribute] BildingmodeBrock Tester;
    
    [System.Serializable]
    public class StartBrock_argument {
        public string brockform;
        public Vector3 pulspos;
        public Vector3 minuspos;
        public GameObject Director;
        public Quaternion rotation;
    }
    [SerializeField, SpaceAttribute] private bool StartBroc;
    [SerializeField] private StartBrock_argument StartBrock_Argument;

    [System.Serializable]
    public class UpdateBurockGraphic_argument {

    }
    [SerializeField, SpaceAttribute] bool UpdateBurockGraphic;
    [SerializeField] UpdateBurockGraphic_argument UpdateBurockGraphic_Argument;
    
    [System.Serializable]
    public class SizeChange_argument {
        public Vector3 normal;
        public Vector3 amount;
    }
    [SerializeField, SpaceAttribute] bool SizeChange;
    [SerializeField] SizeChange_argument SizeChange_Argument;

    [System.Serializable]
    public class MovePostion_argument {
        public Vector3 amount;
    }
    [SerializeField, SpaceAttribute] bool MovePostion;
    [SerializeField] MovePostion_argument MovePostion_Argument;

    [SerializeField, SpaceAttribute] bool Rotate;
    [SerializeField] MovePostion_argument Rotate_Argument;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update(){
        if (StartBroc) {
            Tester.StartBrock(
                StartBrock_Argument.brockform, StartBrock_Argument.pulspos, StartBrock_Argument.minuspos,
                StartBrock_Argument.Director, StartBrock_Argument.rotation);
            StartBroc = false;
        }
        if (UpdateBurockGraphic) {
            Tester.UpdateBurockGraphic();
            UpdateBurockGraphic = false;
        }
        if (SizeChange) {
            Tester.SizeChange(SizeChange_Argument.normal, SizeChange_Argument.amount);
            SizeChange = false;
        }
        if (MovePostion) {
            Tester.MovePostion(MovePostion_Argument.amount);
            MovePostion = false;
        }
        if (Rotate) {
            Tester.Rotate(Rotate_Argument.amount);
            Rotate = false;
        }

        
    }
}
