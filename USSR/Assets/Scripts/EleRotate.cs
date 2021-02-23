using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EleRotate : MonoBehaviour
{ public bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(isActive==true){
            
           GameObject.Find("Player").GetComponent<Gravity>().enabled=true;
        }
        else{
            GameObject.Find("Player").GetComponent<Gravity>().enabled=false;
        }
    }

      private void OnTriggerEnter(Collider other){
        if (other.tag=="Player"){
            isActive=true;

        }
    }

    private void OnTriggerExit(Collider other){
        if(other.tag=="Player"){
            isActive=false;
        }
    }
}
