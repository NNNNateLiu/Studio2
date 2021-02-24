using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorControll : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator Switch;
    public bool isActive;
    private GameObject Level2;
    void Start()
    {
       Level2=GameObject.Find("Trigger2");
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive==true){
           
           Switch.SetBool("Open",true);
           Switch.SetBool("Close",false);
           GameObject.Find("Ele").GetComponent<EleTrace>().enabled=true;
           Level2.SetActive(false);
        }
        else{
            Switch.SetBool("Open",false);
            Switch.SetBool("Close",true);
            GameObject.Find("Ele").GetComponent<EleTrace>().enabled=false;
            Level2.SetActive(true);
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
