using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BildingModeDirectorTester : MonoBehaviour
{
    [SerializeField] BildingModeDirector Tester;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Tester.BrockGraphic.Count);
        for (int num1 = 0; num1 < Tester.BrockGraphic.Count; num1++)
            Debug.Log(Tester.BrockGraphic[num1].name+" num1=%d"+num1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
