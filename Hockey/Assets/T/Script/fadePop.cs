using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadePop : MonoBehaviour {
    private float time;
    private SpriteRenderer SR;
    private Color col;
	// Use this for initialization
	void Start () {
        SR = GetComponent<SpriteRenderer>();
        col = SR.color;
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time > 3.0f)
            time = 0;
        col.a = Mathf.Sin(time);
        SR.color = col;
	}
}
