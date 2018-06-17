using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFrame : MonoBehaviour
{
    private Camera _Camera;
    // Use this for initialization
    void Start()
    {
        _Camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos;
        if (Input.touchCount < 3)
            return ;
        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.touches[i].phase == TouchPhase.Began)
            {
                pos = Input.touches[i].position;
                pos = _Camera.ScreenToWorldPoint(pos);

                Collider2D col = Physics2D.OverlapPoint(pos);
                if (col.transform.tag == "OnItem")
                {
                    Destroy(col.gameObject);
                }
            }
        }
    }
}
