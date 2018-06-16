using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour {
    private Camera _Camera;
    public GameObject Mallet1P;
    public GameObject Mallet2P;
    // Use this for initialization
    void Start () {
        _Camera = Camera.main;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 pos;
        for (int i = 0; i < Input.touchCount; i++)
        {
            pos = Input.touches[i].position;
            pos = _Camera.ScreenToWorldPoint(pos + _Camera.transform.forward * 10);

            if(pos.x > 0)
            {
                Mallet1P.transform.position = pos;
            }
            else
            {
                Mallet2P.transform.position = pos;
            }
        }
    }
}
