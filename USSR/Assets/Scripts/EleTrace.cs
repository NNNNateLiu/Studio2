using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EleTrace : MonoBehaviour


{ private Vector3 Up;
    // Start is called before the first frame update
    void Start()
    {  Up=new Vector3 (0.0f,10.0f,0.0f);
      }

    // Update is called once per frame
    void Update()
    { 
         if(Input.GetMouseButton(0)){
        
         transform.Translate(Up*Time.deltaTime,Space.World);
    }
    if(Input.GetMouseButtonDown(0)){
        
         transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
    }
    }
       
    
}
