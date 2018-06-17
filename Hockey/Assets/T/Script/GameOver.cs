using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
    public Sprite[] Anim;
    int num = 0;
    private SpriteRenderer sr;
    Vector3 StartPos;
    Vector3 EndPos;
    public bool f1P;
    float ti;
    // Use this for initialization
    void Start () {
        sr = GetComponent<SpriteRenderer>();
        Invoke("SpriteChange", 0.1f);
        Vector2 min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        Vector2 max = Camera.main.ViewportToWorldPoint(Vector2.one);
        if (f1P)
        {
            max.x *= 0.15f;
            this.transform.position = new Vector3(min.x - max.x, 0);
            StartPos = this.transform.position;
            EndPos = new Vector3(min.x + max.x, 0, 0);
        }else
        {
            min.x = max.x * 0.15f;
            this.transform.position = new Vector3(max.x + min.x, 0);
            StartPos = this.transform.position;
            EndPos = new Vector3(max.x - min.x, 0, 0);
        }
        

        float worldScreenHeight = Camera.main.orthographicSize * 2f;
        
        float height = sr.sprite.bounds.size.y;

        //  両者の比率を出してスプライトのローカル座標系に反映
        transform.localScale = new Vector3(worldScreenHeight / height / 2, worldScreenHeight / height / 2);
    }
	
	// Update is called once per frame
	void Update () {
        ti += Time.deltaTime * 2;
        this.transform.position = Vector3.Lerp(StartPos,EndPos,ti);
	}

    private void SpriteChange()
    {
        num++;
        sr.sprite = Anim[num];
        if (num < 4)
        {
            Invoke("SpriteChange", 0.1f);
        }
        else{
            Destroy(this.gameObject,0.2f);
        }
    }
}
