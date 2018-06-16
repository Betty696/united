﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour {
    private Camera _Camera;
    public GameObject Mallet1P;
    public GameObject Mallet2P;
    private int No1P = -1;
    private int No2P = -1;
    // Use this for initialization
    void Start () {
        _Camera = Camera.main;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (No1P == -1 && Input.touchCount > 0)
        {
            No1P = Input.touches[0].fingerId;
            if (No1P == No2P)
            {
                No1P = Input.touches[1].fingerId;
            }
        }
        if (No2P == -1 && Input.touchCount > 1)
        {
            No2P = Input.touches[1].fingerId;
            if(No1P == No2P)
            {
                No2P = Input.touches[0].fingerId;
            }
        }

        Vector3 pos;
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
