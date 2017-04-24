﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Start : MonoBehaviour {

    public Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            anim.Play("Sword hit");
        }
        else
        {
            anim.Play("New State");
        }
	}
}
