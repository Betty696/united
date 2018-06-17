using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour {
    public GameObject List1;
    public GameObject List2;
    public GameObject List3;
    private Vector2 min, max;
    // Use this for initialization
    void Start ()
    {
        min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        max = Camera.main.ViewportToWorldPoint(Vector2.one);
        int SclW = 30;
        float subY = max.y * 0.3f;

        List1.transform.localScale = new Vector3(max.y / SclW, max.y / SclW);
        List1.transform.position = new Vector3(max.x - subY, min.y + subY);
        List2.transform.localScale = new Vector3(max.y / SclW, max.y / SclW);
        List2.transform.position = new Vector3(max.x - subY * 2, min.y + subY);
        List3.transform.localScale = new Vector3(max.y / SclW, max.y / SclW);
        List3.transform.position = new Vector3(max.x - subY * 3, min.y + subY);

        this.transform.localRotation = Quaternion.identity;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetUI(GameObject obj)
    {
        if(List1.transform.childCount == 0)
        {
            obj.transform.parent = List1.transform;
            obj.transform.localPosition = Vector3.zero;
        }
        else if (List2.transform.childCount == 0)
        {
            obj.transform.parent = List2.transform;
            obj.transform.localPosition = Vector3.zero;
        }
        else if (List3.transform.childCount == 0)
        {
            obj.transform.parent = List3.transform;
            obj.transform.localPosition = Vector3.zero;
        }
        else
        {
            Destroy(obj);
        }
    }
}
