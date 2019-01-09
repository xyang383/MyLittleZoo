﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swipers : MonoBehaviour {

    private Touch initTouch = new Touch();
    public Camera cam;

    private float rotX = 0f;
    private float rotY = 0f;
    private Vector3 origRot;

    public float rotationSpeed = 0.5f;
    public float dir = -1;

	// Use this for initialization
	void Start () {
        origRot = cam.transform.eulerAngles;
        rotX = origRot.x;
        rotY = origRot.y;
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                initTouch = touch;
            } else if (touch.phase == TouchPhase.Moved)
            {
                //swiping
                float deltaX = initTouch.position.x - touch.position.x;
                float deltaY = initTouch.position.y - touch.position.y;
                rotX -= deltaX * Time.deltaTime * rotationSpeed * dir;
                rotY += deltaY * Time.deltaTime * rotationSpeed * dir;
                cam.transform.eulerAngles = new Vector3(rotX, rotY, 0f);

            } else if (touch.phase == TouchPhase.Ended)
            {
                initTouch = new Touch();
            }
            {

            }
        }
	}
}
