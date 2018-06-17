using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour {
    public AudioClip MallletHitA;
    public AudioClip MallletHitB;
    private AudioSource audioSource;
    // Use this for initialization
    void Start()
    {
        Vector2 max = Camera.main.ViewportToWorldPoint(Vector2.one);
        int SclW = 25;
        this.transform.localScale = new Vector3(max.y / SclW, max.y / SclW);
        audioSource = gameObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("HIT");
        Debug.Log(coll.gameObject.layer);
        if (coll.gameObject.layer == 8)
        {

            Debug.Log(Random.Range(0, 2));
            if (Random.Range(0, 2) == 0)
            {
                audioSource.clip = MallletHitA;
            }
            else
            {
                audioSource.clip = MallletHitB;
            }
            audioSource.Play();
        }
    }

        void OnCollisionEnter2D(Collision2D coll)
    {

    }
}
