using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour {
    public GameObject ItemBlock;
    Vector2 min, max;
    // Use this for initialization
    void Start()
    {
        min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        max = Camera.main.ViewportToWorldPoint(Vector2.one);
        min *= 0.9f;
        max *= 0.9f;
    }
	
	// Update is called once per frame
	void Update () {
		if(transform.childCount < 6 && Random.Range(0,1000) == 0)
        {
            Vector3 pos = new Vector3(Random.Range(min.x,max.x), Random.Range(min.y,max.y));
            Instantiate(ItemBlock, pos, Quaternion.identity, this.transform);
        }
	}
}
