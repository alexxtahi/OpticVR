using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Detect : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name =="P1")
                {
                    print(hit.transform.name);
                    print("suis là");
                }
            }
        }
        
    }
}
