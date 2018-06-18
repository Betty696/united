using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screen : MonoBehaviour
{
	float width = Screen.width;
	float height = Screen.height;

	// Use this for initialization
	void Start()
	{
		Awake();
	}

	// Update is called once per frame
	void Update()
	{

	}

	void Awake()
	{
		float developAspect = 1334.0f / 750.0f;

		// 実機のサイズを取得して、縦横比取得
		float deviceAspect = (float)Screen.width / (float)Screen.height;

		// 実機と開発画面との対比
		float scale = deviceAspect / developAspect;

		Camera mainCamera = Camera.main;

		float deviceSize = mainCamera.orthographicSize;

		float deviceScale = 1.0f / scale;

		mainCamera.orthographicSize = deviceSize * deviceScale;

	}

	private RectTransform hoge;
	public float x, y;


}


