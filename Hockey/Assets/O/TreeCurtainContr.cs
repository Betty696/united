using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCurtainContr : MonoBehaviour {
	Animation anim;

	// Use this for initialization
	void Start ()
	{
		anim = this.gameObject.GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			anim.Play();
		}

		if (Input.touchCount > 0)
		{
			foreach (Touch t in Input.touches)
			{
				if (t.phase == TouchPhase.Began)
				{
					Debug.Log("fid=" + t.fingerId + "x=" + t.position + "y=" + t.position.y);
				}

				anim.Play();
			}
		}
	}
}
