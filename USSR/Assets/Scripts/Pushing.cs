using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Pushing : MonoBehaviour
{
    // the gameobject which hold catching collider

    
    // debug
    public Transform rotatePivot;
    public List<GameObject> catchedCubes;
    public List<GameObject> allCubes;
    public GameObject player;

    // user modify
    public float rotateAngles;
    public GameObject catching;
    private Collider catchingCollider;
    
    private bool isRotate = false;
    private void Start()
    {
        catchingCollider = catching.GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            catching.SetActive(true);
            GetCaughtCubes();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            catching.SetActive(false);
            ReleaseCaughtCubes();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            //catching.SetActive(true);
            Debug.Log("player enter and catch");
            if (Input.GetKeyDown(KeyCode.T))
            {
                //GetCatchedCubes();
                Debug.Log("start to push");
                PushCaughtCubes();
            }
        }
    }

    // catching collider catch cubes
    public void GetCaughtCubes()
    {
        
        foreach (var cube in allCubes)
        {
            bool isCatched = cube.GetComponent<Cubes>().isCatched;
            if (isCatched)
            {
                catchedCubes.Add(cube);
            }
        }
    }

    public void PushCaughtCubes()
    {
        foreach (var cube in catchedCubes)
        {
            cube.transform.SetParent(rotatePivot);
        }

        bool _isX = catching.GetComponent<Catching>().isX;
        if (_isX)
        {
            rotatePivot.DORotate(new Vector3(0,rotateAngles,0),1,RotateMode.Fast);
        }
        else
        {
            rotatePivot.DORotate(new Vector3(rotateAngles,0,0),1,RotateMode.Fast);
        }

        isRotate = true;
    }

    public void ReleaseCaughtCubes()
    {
        catchedCubes.Clear();
    }
    private void Update()
    {
        // a way to dealing with motion sickness (1)
        /*
        if (isRotate)
        {
            Rigidbody rb = player.GetComponent<Rigidbody>();
            rb.constraints = RigidbodyConstraints.None;
            Invoke("SetIsRotate",1);
        }
        else
        {
            Rigidbody rb = player.GetComponent<Rigidbody>();
            rb.constraints = RigidbodyConstraints.FreezeRotation;
        }
        */
    }

    public void SetIsRotate()
    {
        isRotate = false;
    }
}

/*

outerwall - Y axis 
    outer green - clockwise
    outer red - clockwise
innerwall - X asis 
    inner red - clockwise
    inner green - anti

*/