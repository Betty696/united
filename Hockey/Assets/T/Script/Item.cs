using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    int Type = 0;
    [ColorUsage(true, true, 0f, 8f, 0.125f, 3f)]
    public Color small;
    [ColorUsage(true, true, 0f, 8f, 0.125f, 3f)]
    public Color big;
    [ColorUsage(true, true, 0f, 8f, 0.125f, 3f)]
    public Color smoke;
    [ColorUsage(true, true, 0f, 8f, 0.125f, 3f)]
    public Color ice;
    [ColorUsage(true, true, 0f, 8f, 0.125f, 3f)]
    public Color metal;
    [ColorUsage(true, true, 0f, 8f, 0.125f, 3f)]
    public Color thunder;
    private bool Hit = false;
    // Use this for initialization
    void Start ()
    {
        Vector2 max = Camera.main.ViewportToWorldPoint(Vector2.one);
        int SclW = 45;
        this.transform.localScale = new Vector3(max.y / SclW, max.y / SclW);
        Type = Random.Range(0, 6);

        switch (Type)
        {
            case 0:
                GetComponent<SpriteRenderer>().color = small;
                break;
            case 1:
                GetComponent<SpriteRenderer>().color = big;
                break;
            case 2:
                GetComponent<SpriteRenderer>().color = smoke;
                break;
            case 3:
                GetComponent<SpriteRenderer>().color = ice;
                break;
            case 4:
                GetComponent<SpriteRenderer>().color = metal;
                break;
            case 5:
                GetComponent<SpriteRenderer>().color = thunder;
                break;
        }

    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (Hit)
        {
            coll.gameObject.GetComponent<Puck>().SetItemUI(Type);
            Destroy(this.gameObject);
        }
        else
        {
            Hit = true;
        }
    }
}
