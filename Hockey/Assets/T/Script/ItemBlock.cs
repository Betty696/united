using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBlock : MonoBehaviour {
    public GameObject Petal;
    public GameObject Item;
    private int Num;
    private Rigidbody2D rb2d;
    // Use this for initialization
    void Start ()
    {
        Num = Random.Range(3,10);
        float angle = 0;
        for(int i = 0;i < Num; i++)
        {
            Instantiate(Petal, transform.position, Quaternion.Euler(0,0,angle)).transform.parent = this.transform;
            angle += 360 / Num;
        }
        Vector2 max = Camera.main.ViewportToWorldPoint(Vector2.one);
        int SclW = 40;
        this.transform.localScale = new Vector3(max.y / SclW, max.y / SclW);
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        int Cnt = (int)coll.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude/4;
        int No;

        if (Random.Range(0, 2) == 0)
        {
            rb2d.AddTorque((Cnt + 1) * 5);
        }
        else{
            rb2d.AddTorque(-(Cnt + 1) * 5);
        }
        for (int i = 0; i < Cnt; i++)
        {
            No = Random.Range(0, this.transform.childCount);
            this.transform.GetChild(No).gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-2, 2) * 8, Random.Range(-2, 2)*8));
            this.transform.GetChild(No).gameObject.GetComponent<Rigidbody2D>().AddTorque(Random.Range(-6, 6)*10);
            Destroy(this.transform.GetChild(No).gameObject,2.0f);
            this.transform.GetChild(No).parent = null;
            if (this.transform.childCount == 0)
                break;
        }
        if(this.transform.childCount == 0)
        {
            Instantiate(Item, transform.position, Quaternion.Euler(0, 0, Random.Range(0, 360)));
            Destroy(this.gameObject);
        }
    }
}
