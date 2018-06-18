using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
	private string nextScene;
    public GameObject RT;
    public GameObject LT;
    public GameObject AKA;
    public Sprite AKA2;
    public Sprite AKA3;
    public GameObject POP;
    public GameObject Fade;
    private bool on = true;
    private Vector2 min, max;
    private Vector3 RPos, LPos,UPos;
    private Vector3 PopPop;
    private Vector3 AKASCl;
    private float tim = 0;
    private float NOOOOOtim = 0;
    private bool flag = false;
    public GameObject next;
    // Use this for initialization
    void Start()
    {
        min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        max = Camera.main.ViewportToWorldPoint(Vector2.one);
        RPos = new Vector3(max.x * 1.5f,0);
        LPos = new Vector3(min.x * 1.5f,0);
        UPos = new Vector3(0,min.y*1.5f);
        AKASCl = AKA.transform.localScale;
        PopPop = POP.transform.position;
    }

	// Update is called once per frame
	void Update()
	{

        NOOOOOtim += Time.deltaTime;
        if(NOOOOOtim > 2.0f)
        {
            flag = true;
        }
        if(flag && on && Input.touchCount > 0)
        {
            on = false;
            Fade.GetComponent<FadeIn>().Set();
            Invoke("NExt", 1.0f);
            Invoke("Set2", 0.1f);
            Invoke("Set3", 0.4f);

        }
        else
        {
            if (on == false)
            {
                tim += Time.deltaTime / 2;
                RT.transform.position = Vector3.Lerp(Vector3.zero, RPos, tim);
                LT.transform.position = Vector3.Lerp(Vector3.zero, LPos, tim);
                POP.transform.position = Vector3.Lerp(PopPop, UPos, tim);
                AKA.transform.localScale = Vector3.Lerp(AKASCl,Vector3.zero,tim);
            }
        }
	}

    void NExt()
    {
        Instantiate(next);
    }

    void Set2()
    {
        AKA.GetComponent<SpriteRenderer>().sprite = AKA2;
    }
    void Set3()
    {
        AKA.GetComponent<SpriteRenderer>().sprite = AKA3;
    }
}
