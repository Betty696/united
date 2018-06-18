using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVUp : MonoBehaviour
{
    private Vector3 star = new Vector3(0, -15, 0);
    private Vector3 tra = new Vector3(0,0.01f,0);
    private Vector3 trax = new Vector3(0.05f,0,0);
    private Vector2 min, max, now;
    private float tim;
    private bool on;
	// Use this for initialization
	void Start ()
    {
        min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        max = Camera.main.ViewportToWorldPoint(Vector2.one);
        min.x *= 0.001f;
        max.x *= 0.001f;
    }

    // Update is called once per frame
    void Update()
    {
        tim += Time.deltaTime * 0.2f;
        if (on)
        {
            now = Vector3.Lerp(min, max, tim);
        }
        else
        {
            now = Vector3.Lerp(max, min, tim);
        }
        if (tim > 1.0f)
        {
            tim = 0.0f;
        }
        tra.x = now.x;
        transform.Translate(tra);
        if (transform.position.y >= 15.0f)
        {
            transform.position = star;
        }
    }
}
