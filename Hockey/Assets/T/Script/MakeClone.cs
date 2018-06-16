using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeClone : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Transform clone = Instantiate(transform.parent,transform.position,Quaternion.identity);
        Destroy(clone.Find("MakeClone").gameObject);
        Rigidbody2D rb2D = clone.GetComponent<Rigidbody2D>();
        Vector3 vel = rb2D.velocity;
        vel.y *= -1;
        rb2D.velocity = vel;
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(this.gameObject);
    }
}
