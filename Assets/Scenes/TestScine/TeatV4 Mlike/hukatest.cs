using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hukatest : MonoBehaviour
{
    [SerializeField] GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        for(int num1 =0;num1<16;num1++)
            for (int num2 = 0; num2 < 64; num2++)
                for (int num3 = 0; num3 < 16; num3++) {
                    GameObject ins = Instantiate(cube);
                    ins.transform.position = new Vector3(num1, num2, num3);
                }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
