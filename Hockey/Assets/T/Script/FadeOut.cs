using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    private SpriteRenderer SR;
    private Color col;
    // Use this for initialization
    void Start ()
    {
        SR = GetComponent<SpriteRenderer>();
        col = SR.color;
        Destroy(this.gameObject, 5.0f);
    }
	
	// Update is called once per frame
	void Update ()
    {
            col.a -= 0.03f;
            SR.color = col;
    }
}
