using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Rigidbody2D rb2D = GetComponent<Rigidbody2D>();
        Vector3 vel = rb2D.velocity;
        vel.y *= -1;
        rb2D.velocity = vel;
        Destroy(this.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
