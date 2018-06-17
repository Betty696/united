using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : MonoBehaviour
{
    public Sprite ice;
    // Use this for initialization
    void Start ()
    {
        transform.parent.gameObject.GetComponent<Puck>().Pow = 30;
        transform.parent.gameObject.GetComponent<SpriteRenderer>().sprite = ice;
        Destroy(this.gameObject, 3.0f);
    }
    void OnDestroy()
    {
        transform.parent.gameObject.GetComponent<Puck>().Pow = 20;
        transform.parent.gameObject.GetComponent<SpriteRenderer>().sprite = transform.parent.gameObject.GetComponent<Puck>().Image;
    }

    // Update is called once per frame
    void Update () {
    }
}
