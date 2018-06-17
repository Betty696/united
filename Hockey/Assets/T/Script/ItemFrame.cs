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
                Ray ray = Camera.main.ScreenPointToRay(pos);
                RaycastHit hit = new RaycastHit();
                if (Physics.Raycast(ray, out hit))
                {
                    //Rayを飛ばしてあたったオブジェクトが自分自身だったら
                    if (hit.collider.transform.tag == "OnItem")
                    {
                        Destroy(hit.collider.transform.gameObject);
                    }
                }
            }
        }
    }
}
