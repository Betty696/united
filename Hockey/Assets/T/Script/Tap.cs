using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour {
    private Camera _Camera;
    public GameObject Mallet1P;
    public GameObject Mallet2P;
    private int No1P = -1;
    private int No2P = -1;
    public bool On = true;
    // Use this for initialization
    void Start () {
        _Camera = Camera.main;
    }
	
	// Update is called once per frame
	void LateUpdate ()
    {
        if (!On)
        {
            return;
        }

        Vector3 pos;

        if (No1P == -1 && Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                pos = Input.touches[i].position;
                if (Input.touches[i].phase == TouchPhase.Began && _Camera.ScreenToWorldPoint(pos + _Camera.transform.forward * 10).x > 0)
                {
                    No1P = Input.touches[i].fingerId;
                    break;
                }
            }
        }
        if (No2P == -1 && Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                pos = Input.touches[i].position;
                if (Input.touches[i].phase == TouchPhase.Began && _Camera.ScreenToWorldPoint(pos + _Camera.transform.forward * 10).x < 0)
                {
                    No2P = Input.touches[i].fingerId;
                    break;
                }
            }
        }

        for (int i = 0; i < Input.touchCount; i++)
        {
            if (No1P == Input.touches[i].fingerId)
            {
                pos = Input.touches[i].position;
                pos = _Camera.ScreenToWorldPoint(pos + _Camera.transform.forward * 10);

                Mallet1P.transform.position = pos;
                if (Input.touches[i].phase == TouchPhase.Ended)
                {
                    No1P = -1;
                }
            }
            if (No2P == Input.touches[i].fingerId)
            {
                pos = Input.touches[i].position;
                pos = _Camera.ScreenToWorldPoint(pos + _Camera.transform.forward * 10);

                Mallet2P.transform.position = pos;
                if(Input.touches[i].phase == TouchPhase.Ended)
                {
                    No2P = -1;
                }
            }
        }
    }
}
