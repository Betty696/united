using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUI : MonoBehaviour {
    public GameObject palent;
    public Sprite[] UI;
    public GameObject[] Effect;
    public GameObject[] UseSE;
    public int Type;
    // Use this for initialization
    void Start ()
    {
        GetComponent<SpriteRenderer>().sprite = UI[Type];
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Use()
    {
        Instantiate(Effect[Type], palent.transform.position,Quaternion.identity, palent.transform);
        Destroy(Instantiate(UseSE[Type]),4.0f);
    }
}
