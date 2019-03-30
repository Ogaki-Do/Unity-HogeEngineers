using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrugTest : MonoBehaviour
{
    [SerializeField] GameObject Maincamera;
    [SerializeField] Vector3 clickPosition;
    [SerializeField] GameObject Prefab;
    // Start is called before the first frame update
    void Start(){
       Maincamera = GameObject.FindGameObjectsWithTag("MainCamera")[0];
        
    }

    public void Update () {
        if (Input.GetMouseButtonDown(0)) {
           
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit)) {
                Debug.Log(hit.point);
                clickPosition = hit.point;
                Debug.Log(hit.normal);
                Instantiate(Prefab, clickPosition, Prefab.transform.rotation);
            }

            
        }
    }



    // Update is called once per frame
    


}
