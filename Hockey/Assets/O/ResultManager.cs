using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour {

	private string nextScene;

	// シーンが始まってからのカウンタ
	private int m_nTime;

// ボタン入力を受け付けない秒数
	public int m_nFreezTime = 120;

	// Use this for initialization
    void Start()
    {
        m_nTime = 0;

		// フェードへの参照を取得
        Fade fade = GameObject.FindGameObjectWithTag("Fade").GetComponent<Fade>();

		//フェードイン
		fade.FadeIn();
	}

	// Update is called once per frame
	void Update()
	{
		//時間のカウントアップ
		m_nTime++;

		if(m_nTime > m_nFreezTime)
		{
			if (Input.GetMouseButton(0))
			{
				ChangeScene("TitleScene");
			}

			if (Input.touchCount > 0)
			{
				foreach (Touch t in Input.touches)
				{
					if (t.phase == TouchPhase.Began)
					{
						Debug.Log("fid=" + t.fingerId + "x=" + t.position + "y=" + t.position.y);
					}

					ChangeScene("TitleScene");
				}
			}
		}

		//フェードへの参照を取得
		Fade fade = GameObject.Find("Fade").GetComponent<Fade>();
		
		//フェードが終わったら遷移
		if (fade.isFinishedFadeOut())
		{
			SceneManager.LoadScene(nextScene);
		}
	}

	//ゲームへ遷移開始
	public void ChangeScene(string sceneName)
	{
		nextScene = sceneName;

		//フェードアウト開始
		Fade fade = GameObject.FindGameObjectWithTag("Fade").GetComponent<Fade>();
		fade.FadeOut();
    }
}
