﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mallet : MonoBehaviour {
    private Vector3 OldPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        OldPos = transform.position;
		
	}

    void OnTriggerEnter2D(Collider2D c)
    {
        Rigidbody2D rb2D = c.GetComponent<Rigidbody2D>();
        Vector3 Pow = (transform.position - OldPos) * 0.001f;
        if (Pow == Vector3.zero)
        {
            Vector3 vel = rb2D.velocity;
            vel.x *= -1;
            rb2D.velocity = vel;
        }
        else
        {
            rb2D.AddForce(Pow,ForceMode2D.Impulse);
        }
    }
}
