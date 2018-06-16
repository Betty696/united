using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour {
    public GameObject Top;
    public GameObject Under;
    public GameObject Right;
    public GameObject Left;
    Vector2 min,max;
    // Use this for initialization
    void Start () {
        min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        max = Camera.main.ViewportToWorldPoint(Vector2.one);

        Top.transform.position = new Vector3(0,min.y,0);
        Under.transform.position = new Vector3(0,max.y,0);
        Right.transform.position = new Vector3(max.x,0,0);
        Left.transform.position = new Vector3(min.x,0,0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
