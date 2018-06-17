using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder : MonoBehaviour {
    Rigidbody2D rb2D;
    // Use this for initialization
    void Start()
    {
        Vector2 max = Camera.main.ViewportToWorldPoint(Vector2.one);
        int SclW = 5;
        for(int i = 0; i < 4; i++)
        {
            transform.GetChild(i).gameObject.GetComponent<ParticleSystem>().startSize = max.y / SclW;
        }
        rb2D = transform.parent.GetComponent<Rigidbody2D>();
        rb2D.velocity = Vector3.zero;
    }
	
	// Update is called once per frame
	void Update () {
		if(rb2D.velocity.magnitude > 0.2f)
        {
            Destroy(this.gameObject);
        }
	}
}
