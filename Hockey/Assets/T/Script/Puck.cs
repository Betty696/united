using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour {
    public GameObject P1ItmeList;
    public GameObject P2ItmeList;
    private ItemList P1List;
    private ItemList P2List;
    public GameObject ItemUI;
    public Sprite[] MalletHitSprite;
    public AudioClip[] MallletHit;
    public GameObject ItemHit;
    private int LastHitSe;
    private AudioSource audioSource;
    private int LastHit = 0;
    public int Pow = 20;
    public Vector3 Scl;
    public Sprite Image;
    public GameObject Tap;
    private SpriteRenderer SP;
    private Rigidbody2D rb2D;
    // Use this for initialization
    void Start()
    {
        Vector2 max = Camera.main.ViewportToWorldPoint(Vector2.one);
        int SclW = 25;
        this.transform.localScale = new Vector3(max.y / SclW, max.y / SclW);
        Scl = this.transform.localScale;
        SP = GetComponent<SpriteRenderer>();
        Image = SP.sprite;
        audioSource = gameObject.GetComponent<AudioSource>();
        P1List = P1ItmeList.GetComponent<ItemList>();
        P2List = P2ItmeList.GetComponent<ItemList>();
        rb2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
    }

    void FixedUpdate()
    {
        float speed = rb2D.velocity.magnitude / Pow;
        if (speed > 1.0f)
        {
            rb2D.velocity = rb2D.velocity.normalized * Pow;
        }
    }

    void OnDestroy()
    {
        Tap.GetComponent<Tap>().On = false;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.layer == 8)
        {
            if (audioSource.isPlaying == false)
            {
                int NO = Random.Range(0, MallletHit.Length);
                while (LastHitSe == NO)
                {
                    NO = Random.Range(0, MallletHit.Length);
                }
                LastHitSe = NO;
                audioSource.clip = MallletHit[NO];
                audioSource.Play();
                if(SP.sprite == Image)
                {
                    SP.sprite = MalletHitSprite[NO];
                    Invoke("ReSetSprite", 1.0f);
                }
            }
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

    void ReSetSprite()
    {
        SP.sprite = Image;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.transform.tag == "1")
        {
            LastHit = 1;
        }
        if (coll.transform.tag == "2")
        {
            LastHit = 2;
        }
    }

    public void SetItemUI(int type)
    {
        Destroy(Instantiate(ItemHit),5.0f);
        GameObject UI = Instantiate(ItemUI) as GameObject;
        UI.GetComponent<ItemUI>().Type = type;
        UI.GetComponent<ItemUI>().palent = this.gameObject;
        if(LastHit == 1)
        {
            UI.transform.localRotation = Quaternion.Euler(0,0,90);
            P1List.SetUI(UI);
        }
        else
        {
            UI.transform.localRotation = Quaternion.Euler(0, 0, -90);
            P2List.SetUI(UI);
        }
    }
}
