using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour {
    private Vector3 EndScl;
    private Vector3 rot = new Vector3(0,0,0);
    float ti;
	// Use this for initialization
	void Start () {
        Color col = GetComponent<SpriteRenderer>().color;
        col.a = 0.5f;
        GetComponent<SpriteRenderer>().color = col;
        EndScl = this.transform.localScale;
        rot.z = Random.Range(3, 30);
        Destroy(this, 1);
	}
    
    void OnDestroy()
    {
        this.transform.localScale = EndScl;
    }
	
	// Update is called once per frame
	void Update () {
        ti += Time.deltaTime;
        this.transform.localScale = Vector3.Lerp(Vector3.zero,EndScl,ti);
        this.transform.Rotate(rot);
    }
}
