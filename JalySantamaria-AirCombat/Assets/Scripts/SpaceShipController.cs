﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
     if(Input.GetKey(KeyCode.RightArrow)) {
            this.transform.Translate(Vector3.right);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            this.transform.Translate(Vector3.left);
        }
    }
}
