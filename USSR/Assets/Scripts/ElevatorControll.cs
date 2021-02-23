using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorControll : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator Switch;
    public bool isActive;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive==true){
            if(Input.GetMouseButtonDown(0)){
           Switch.SetBool("Open",true);
           Switch.SetBool("Close",false);
           }
           
           GameObject.Find("Ele").GetComponent<EleTrace>().enabled=true;
        }
        else{
            Switch.SetBool("Open",false);
            Switch.SetBool("Close",true);
           
            GameObject.Find("Ele").GetComponent<EleTrace>().enabled=false;
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
