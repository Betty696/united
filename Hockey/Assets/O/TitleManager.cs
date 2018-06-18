using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
	private string nextScene;

	// Use this for initialization
	void Start()
	{
		//フェードへの参照を取得
		Fade fade = GameObject.FindGameObjectWithTag("Fade").GetComponent<Fade>();

		//フェードイン
		fade.FadeIn();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			ChangeScene("MainScene");
		}

		if (Input.touchCount > 0)
		{
			foreach (Touch t in Input.touches)
			{
				if (t.phase == TouchPhase.Began)
				{
					Debug.Log("fid=" + t.fingerId + "x=" + t.position + "y=" + t.position.y);
				}

				ChangeScene("MainScene");
			}
		}

	// フェードへの参照を取得
	Fade fade = GameObject.FindGameObjectWithTag("Fade").GetComponent<Fade>();

		// フェードが終わったら遷移
		if (fade.isFinishedFadeOut())
		{
			SceneManager.LoadScene(nextScene);
		}
	}

	// メインへ遷移開始
	public void ChangeScene(string sceneName)
	{
		nextScene = sceneName;

		Fade fade = GameObject.FindGameObjectWithTag("Fade").GetComponent<Fade>();
		fade.FadeOut();
	}
}
