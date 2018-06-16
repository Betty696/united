using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Vector2 max = Camera.main.ViewportToWorldPoint(Vector2.one);
        int SclW = 25;
        this.transform.localScale = new Vector3(max.y / SclW, max.y / SclW);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
