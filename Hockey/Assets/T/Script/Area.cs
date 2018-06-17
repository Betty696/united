using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour {
    public GameObject Top;
    public GameObject Under;
    public GameObject Right;
    public GameObject Left;
    private Vector2 min,max;
    // Use this for initialization
    void Start () {
        min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        max = Camera.main.ViewportToWorldPoint(Vector2.one);
        Vector2 min2 = min * 0.1f;
        Vector2 max2 = max * 0.1f;
        Top.transform.position = new Vector3(0,max.y - max2.y, 0);
        Under.transform.position = new Vector3(0,min.y - min2.y,0);
        Right.transform.position = new Vector3(max.x - max2.x, 0,0);
        Left.transform.position = new Vector3(min.x - min2.x, 0,0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
