using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {
  float FORCE_OF_GRAVITY = 100F;
  
  void Start () {
    Debug.Log("Start");
  }
  void Update () {
    // Change gravity on mouse click
    if (Input.GetMouseButtonDown(0)) {
      if (Physics.gravity.y > 0) {
        // Normal gravity so downward force of -9.8
        Physics.gravity = new Vector3(0, FORCE_OF_GRAVITY * (-1), 0);
        gameObject.GetComponent<MouseLook>().enabled=false;
        gameObject.transform.Rotate(180.0f, 0.0f, 0.0f, Space.World);
      } else {
        // Inverse gravity
        Physics.gravity = new Vector3(0, FORCE_OF_GRAVITY, 0);
      }
    }
  }
}
