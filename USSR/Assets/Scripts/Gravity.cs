using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {
  float FORCE_OF_GRAVITY = 10F;
  
  void Start () {
    Debug.Log("Start");
  }
  void Update () {
    // Change gravity on mouse click
    if (Input.GetMouseButtonDown(0)) {
      if (Physics.gravity.y > 0) {
        // Normal gravity so downward force of -9.8
        Physics.gravity = new Vector3(FORCE_OF_GRAVITY, 0, 0);
        gameObject.GetComponent<MouseLook>().enabled=false;
        gameObject.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
      } 
      else if(Physics.gravity.x>0&&Physics.gravity.y==0){
        Physics.gravity = new Vector3(0,FORCE_OF_GRAVITY*(-1.0f), 0);
        gameObject.GetComponent<MouseLook>().enabled=false;
        gameObject.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);

      }
      else if (Physics.gravity.y<0){
        Physics.gravity = new Vector3(FORCE_OF_GRAVITY*(-1.0f),0,0);
        gameObject.GetComponent<MouseLook>().enabled=false;
        gameObject.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
      }
      else {
        // Inverse gravity
        Physics.gravity = new Vector3(0, FORCE_OF_GRAVITY, 0);
        gameObject.GetComponent<MouseLook>().enabled=true;
        gameObject.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
      }
    }
  }
}
