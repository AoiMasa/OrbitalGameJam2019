﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Rigidbody2D rbody = collision.gameObject.GetComponent<Rigidbody2D>();
            rbody.AddForceAtPosition(new Vector2(100, 100), this.transform.position);
            Debug.Log("Touché2");
        }
    }
}
