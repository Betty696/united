using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Big : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        transform.parent.localScale = transform.parent.gameObject.GetComponent<Puck>().Scl * 1.5f;
        Destroy(this.gameObject, 3.0f);
    }
    void OnDestroy()
    {
        transform.parent.localScale = transform.parent.gameObject.GetComponent<Puck>().Scl;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
