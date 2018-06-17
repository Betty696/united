using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metal : MonoBehaviour {
    public Sprite metal;
    // Use this for initialization
    void Start ()
    {
        transform.parent.gameObject.GetComponent<Puck>().Pow = 10;
        transform.parent.gameObject.GetComponent<SpriteRenderer>().sprite = metal;
        Destroy(this.gameObject, 3.0f);
    }

    void OnDestroy()
    {
        transform.parent.gameObject.GetComponent<Puck>().Pow = 20;
        transform.parent.gameObject.GetComponent<SpriteRenderer>().sprite = transform.parent.gameObject.GetComponent<Puck>().Image;
    }

    // Update is called once per frame
    void Update ()
    {
    }
}
