using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour {
    private SpriteRenderer SR;
    private Color col;
    private float tim = -1;
	// Use this for initialization
	void Start () {
        SR = GetComponent<SpriteRenderer>();
        col = SR.color;
	}
	
	// Update is called once per frame
	void Update () {
		if(!(tim < 0))
        {
            col.a += 0.03f;
            SR.color = col;
        }
	}
    public void Set()
    {
        tim = 0.0f;
    }
}
