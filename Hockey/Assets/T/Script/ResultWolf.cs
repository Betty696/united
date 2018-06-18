using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultWolf : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        // カメラの外枠のスケールをワールド座標系で取得
        float worldScreenHeight = Camera.main.orthographicSize * 2f;
        float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

        // スプライトのスケールもワールド座標系で取得
        float width = sr.sprite.bounds.size.x;
        float height = sr.sprite.bounds.size.y;

        //  両者の比率を出してスプライトのローカル座標系に反映
        transform.localScale = new Vector3(worldScreenWidth / width / 2, worldScreenHeight / height / 2);

        // カメラの中心とスプライトの中心を合わせる
        Vector3 camPos = Camera.main.transform.position;
        camPos.z = 0;
        transform.position = camPos;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
