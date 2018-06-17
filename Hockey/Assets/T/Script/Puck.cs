using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour {
    public GameObject P1ItmeList;
    public GameObject P2ItmeList;
    private ItemList P1List;
    private ItemList P2List;
    public GameObject ItemUI;
    public AudioClip MallletHitA;
    public AudioClip MallletHitB;
    private AudioSource audioSource;
    private int LastHit = 0;
    public int Pow = 20;
    public Vector3 Scl;
    public Sprite Image;
    // Use this for initialization
    void Start()
    {
        Vector2 max = Camera.main.ViewportToWorldPoint(Vector2.one);
        int SclW = 25;
        this.transform.localScale = new Vector3(max.y / SclW, max.y / SclW);
        Scl = this.transform.localScale;
        Image = GetComponent<SpriteRenderer>().sprite;
        audioSource = gameObject.GetComponent<AudioSource>();
        P1List = P1ItmeList.GetComponent<ItemList>();
        P2List = P2ItmeList.GetComponent<ItemList>();
    }
	
	// Update is called once per frame
	void Update () {
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.layer == 8)
        {
            if (Random.Range(0, 2) == 0)
            {
                audioSource.clip = MallletHitA;
            }
            else
            {
                audioSource.clip = MallletHitB;
            }
            audioSource.Play();
            if(coll.transform.tag == "1")
            {
                LastHit = 1;
            }
            else
            {
                LastHit = 2;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
    }

    public void SetItemUI(int type)
    {
        GameObject UI = Instantiate(ItemUI) as GameObject;
        UI.GetComponent<ItemUI>().Type = type;
        UI.GetComponent<ItemUI>().palent = this.gameObject;
        if(LastHit == 1)
        {
            P1List.SetUI(UI);
        }
        else
        {
            P2List.SetUI(UI);
        }
    }
}
