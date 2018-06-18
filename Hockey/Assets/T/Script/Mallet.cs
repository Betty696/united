using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mallet : MonoBehaviour {
    private Vector3 OldPos;
    private Rigidbody2D rb2d;
    // Use this for initialization
    void Start ()
    {
        Vector2 max = Camera.main.ViewportToWorldPoint(Vector2.one);
        int SclW = 20;
        this.transform.localScale = new Vector3(max.y / SclW, max.y / SclW);
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        OldPos = transform.position;
		
	}

    void FixedUpdate()
    {
        rb2d.velocity = (this.transform.position - OldPos) * 10;
    }
}
