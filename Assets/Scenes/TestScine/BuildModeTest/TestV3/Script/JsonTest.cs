using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonTest : MonoBehaviour {
    public const int Xpuls = 0;
    //0->+x
    public const int Zminus = 1;
    //1->-z
    public const int Xminus = 2;
    //2->+z
    public const int Zpuls = 3;
    //3->-z
    public const int Yminus = 4;
    //4->-y
    public const int Ypuls = 5;

    [SerializeField] Vector3Int size=new Vector3Int(1,1,1);
    WallDataTest wall = new WallDataTest();


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void wallcriate (){
       
    }
}

[System.Serializable]
public class WallDataTest {

    public bool[,] Xpuls;
    //0->+x
    public bool[,] Zminus;
    //1->-z
    public bool[,] Xminus;
    //2->+z
    public bool[,] Zpuls;
    //3->-z
    public bool[,] Yminus;
    //4->-y
    public bool[,] Ypuls;
    //5->-x
    public bool[,] WallDataOutput(int x) {
        switch (x) {
            case 0:
                return Xpuls;
            case 1:
                return Zminus;
            case 2:
                return Xminus;
            case 3:
                return Zpuls;
            case 4:
                return Yminus;
            case 5:
                return Ypuls;
        }
        return null;
    }
    public void WallDataInput(int[,] data,int x) {
    }
}